using FinalDay_ITI.Controllers;
using FinalDay_ITI.Views.Partials;
using FinalDay_ITI.Views.User;

namespace FinalDay_ITI.Views;

public partial class Dashboard : Form
{
    private UserControl? _currentPage;
    private readonly Dictionary<string, UserControl> _pages;

    public Dashboard()
    {
        InitializeComponent();

        _pages = new()
        {
            { "Home", new HomePage() },
            { "Users", new GridViewPage(UserController.Index) },
            { "Categories", new GridViewPage(CategoryController.Index) },
            { "Medicines", new GridViewPage(MedicineController.Index) },
            { "Orders", new GridViewPage(OrderController.Index) },
            { "MyOrders", new GridViewPage(AuthController.History) },
            { "Settings", new SettingsPage() },
        };

        LayoutPanel.Controls.AddRange(_pages.Select(page => page.Value).ToArray());
        ChangePageTo("Home");

        // set events 
        ((GridViewPage)_pages["Users"]).OnClickBtns += UsersBtns_Click;
        ((GridViewPage)_pages["Categories"]).OnClickBtns += CategoriesBtns_Click;
        ((GridViewPage)_pages["Medicines"]).OnClickBtns += MedicinesBtns_Click;
        ((GridViewPage)_pages["Orders"]).OnClickBtns += OrdersBtns_Click;
        ((GridViewPage)_pages["MyOrders"]).OnClickBtns += OrdersBtns_Click;
        ((SettingsPage)_pages["Settings"]).editInfo1.OnRefresh += dashboardHeader.Refresh;

        dashboardHeader.OnClickMenuBtn += navSideBar1.ShowOrHidePanel;
        navSideBar1.OnClickBtn += ChangePage;
    }

    private void ChangePage(object? sender, EventArgs e)
    {
        if (sender is Button b) ChangePageTo(b.Text);
    }

    public void ChangePageTo(string page)
    {
        if (_currentPage != null) _currentPage.Visible = false;
        _currentPage = _pages[page];
        _currentPage.Refresh();
        _currentPage.Visible = true;
    }

    #region routes
    private void UsersBtns_Click(object? sender, DataGridView e)
    {
        if (sender is not Button b) return;

        switch (b.Name)
        {
            case "AddBtn": UserController.Create(this); break;
            case "EditBtn": UserController.Edit(Convert.ToInt32(e.CurrentRow.Cells["id"].Value), this); break;
            case "DeleteBtn": UserController.Delete(Convert.ToInt32(e.CurrentRow.Cells["id"].Value), this); break;
            default: break;
        }

        _currentPage?.Refresh();
    }

    private void CategoriesBtns_Click(object? sender, DataGridView e)
    {
        if (sender is not Button b) return;

        switch (b.Name)
        {
            case "AddBtn": CategoryController.Create(this); break;
            case "EditBtn": CategoryController.Edit(Convert.ToInt32(e.CurrentRow.Cells["id"].Value), this); break;
            case "DeleteBtn": CategoryController.Delete(Convert.ToInt32(e.CurrentRow.Cells["id"].Value), this); break;
            default: break;
        }

        _currentPage?.Refresh();
    }

    private void MedicinesBtns_Click(object? sender, DataGridView e)
    {
        if (sender is not Button b) return;

        switch (b.Name)
        {
            case "AddBtn": MedicineController.Create(this); break;
            case "EditBtn": MedicineController.Edit(Convert.ToInt32(e.CurrentRow.Cells["id"].Value), this); break;
            case "DeleteBtn": MedicineController.Delete(Convert.ToInt32(e.CurrentRow.Cells["id"].Value), this); break;
            default: break;
        }

        _currentPage?.Refresh();
    }

    private void OrdersBtns_Click(object? sender, DataGridView e)
    {
        if (sender is not Button b) return;

        switch (b.Name)
        {
            case "AddBtn": OrderController.Create(this); break;
            case "EditBtn": OrderController.Edit(Convert.ToInt32(e.CurrentRow.Cells["id"].Value), this); break;
            case "DeleteBtn": OrderController.Delete(Convert.ToInt32(e.CurrentRow.Cells["id"].Value), this); break;
            default: break;
        }

        _currentPage?.Refresh();
    }
    #endregion
}
