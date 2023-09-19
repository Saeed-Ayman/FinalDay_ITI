using FinalDay_ITI.Controllers;
using FinalDay_ITI.Views.Order;
using FinalDay_ITI.Views.Partials;
using FinalDay_ITI.Views.User;

namespace FinalDay_ITI.Views;

public partial class Dashboard : Form
{
    private UserControl _currentPage;
    private readonly Dictionary<string, UserControl> _pages;

    public Dashboard()
    {
        InitializeComponent();

        _pages = new()
        {
            { "Home", new HomePage() { Dock=DockStyle.Fill, Visible=true } },
            { "Users", new GridViewPage(UserController.Index) { Dock=DockStyle.Fill, Visible=false } },
            { "Categories", new GridViewPage(CategoryController.Index) { Dock=DockStyle.Fill, Visible=false } },
            { "Medicines", new GridViewPage(MedicineController.Index) { Dock=DockStyle.Fill, Visible=false } },
            { "Orders", new GridViewPage(OrderController.Index) { Dock=DockStyle.Fill, Visible=false } },
            { "Create Order", new AddOrdera() { Dock=DockStyle.Fill, Visible=false } },
            { "History", new GridViewPage(AuthController.History, false) { Dock=DockStyle.Fill, Visible=false } },
            { "Settings", new SettingsPage() { Dock=DockStyle.Top, AutoScroll=true, Visible=false } },
        };

        foreach (var (key, value) in _pages)
            LayoutPanel.Controls.Add(value);

        _currentPage = _pages["Home"];

        // set events 
        ((GridViewPage)_pages["Users"]).OnClickBtns += UsersBtns_Click;
        ((GridViewPage)_pages["Categories"]).OnClickBtns += CategoriesBtns_Click;
        ((GridViewPage)_pages["Medicines"]).OnClickBtns += MedicinesBtns_Click;
        ((GridViewPage)_pages["Orders"]).OnClickBtns += OrdersBtns_Click;
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
        _currentPage.Visible = false;
        _currentPage = _pages[page];
        _currentPage.Refresh();
        _currentPage.Visible = true;
    }

    private void UsersBtns_Click(object? sender, DataGridView e)
    {
        if (sender is not Button b) return;

        switch (b.Name)
        {
            case "AddBtn":
                UserController.Create(this);
                break;
            case "EditBtn":
                var id = e.CurrentRow.Cells["id"].Value;
                if (id == null) break;
                UserController.Edit((int)id, this);
                break;
            case "DeleteBtn":
                var idd = e.CurrentRow.Cells["id"].Value;
                if (idd == null) break;
                UserController.Delete((int)idd, this);
                break;
            default:
                break;
        }

        _currentPage.Refresh();
    }

    private void CategoriesBtns_Click(object? sender, DataGridView e)
    {
        if (sender is not Button b) return;

        switch (b.Name)
        {
            case "AddBtn":
                CategoryController.Create(this);
                break;
            case "EditBtn":
                CategoryController.Edit((int)e.CurrentRow.Cells["id"].Value, this);
                break;
            case "DeleteBtn":
                CategoryController.Delete((int)e.CurrentRow.Cells["id"].Value, this);
                break;
            default:
                break;
        }

        _currentPage.Refresh();
    }

    private void MedicinesBtns_Click(object? sender, DataGridView e)
    {
        if (sender is not Button b) return;

        switch (b.Name)
        {
            case "AddBtn":
                MedicineController.Create(this);
                break;
            case "EditBtn":
                MedicineController.Edit((int)e.CurrentRow.Cells["Id"].Value, this);
                break;
            case "DeleteBtn":
                MedicineController.Delete((int)e.CurrentRow.Cells["Id"].Value, this);
                break;
            default:
                break;
        }

        _currentPage.Refresh();
    }

    private void OrdersBtns_Click(object? sender, DataGridView e)
    {
        if (sender is not Button b) return;

        switch (b.Name)
        {
            case "AddBtn":
                OrderController.Create(this);
                break;
            case "EditBtn":
                OrderController.Show((int)e.CurrentRow.Cells["Id"].Value, this);
                break;
            case "DeleteBtn":
                MessageBox.Show("Not Supported Now!");
                break;
            default:
                break;
        }

        _currentPage.Refresh();
    }
}
