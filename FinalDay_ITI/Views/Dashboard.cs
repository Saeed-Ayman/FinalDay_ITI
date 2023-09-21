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
            { "Users", new GridViewPage(nameof(UserController)) },
            { "Categories", new GridViewPage(nameof(CategoryController)) },
            { "Medicines", new GridViewPage(nameof(MedicineController)) },
            { "Expired Medicines", new GridViewPage(nameof(ExpiredMedicinesController), Buttons: false) },
            { "Out of Stocks", new GridViewPage(nameof(OutOfStocksController), Buttons: false) },
            { "Orders", new GridViewPage(nameof(OrderController)) },
            { "MyOrders", new GridViewPage(nameof(UserOrderController)) },
            { "Settings", new SettingsPage() },
        };

        ((GridViewPage)_pages["Users"]).OnClickBtns += UsersBtns_Click;
        ((GridViewPage)_pages["Categories"]).OnClickBtns += CategoriesBtns_Click;
        ((GridViewPage)_pages["Medicines"]).OnClickBtns += MedicinesBtns_Click;
        ((GridViewPage)_pages["Orders"]).OnClickBtns += OrdersBtns_Click;
        ((GridViewPage)_pages["MyOrders"]).OnClickBtns += OrdersBtns_Click;
        ((SettingsPage)_pages["Settings"]).editInfo1.OnRefresh += dashboardHeader.Refresh;

        dashboardHeader.OnClickMenuBtn += navSideBar1.ShowOrHidePanel;
        navSideBar1.OnClickBtn += ChangePage;

        LayoutPanel.Controls.AddRange(_pages.Select(page => page.Value).ToArray());
        ChangePageTo("Home");
    }


    public void ChangePageTo(string page)
    {
        if (_currentPage != null) _currentPage.Visible = false;
        _currentPage = _pages[page];
        _currentPage.Refresh();
        _currentPage.Visible = true;
    }

    private void ChangePage(object? sender, EventArgs e) { if (sender is Button b) ChangePageTo(b.Text); }

    #region routes
    private void UsersBtns_Click(object? sender, DataGridView e) => Router(sender, e, UserController.Create, UserController.Edit, UserController.Delete);
    private void CategoriesBtns_Click(object? sender, DataGridView e) => Router(sender, e, CategoryController.Create, CategoryController.Edit, CategoryController.Delete);
    private void MedicinesBtns_Click(object? sender, DataGridView e) => Router(sender, e, MedicineController.Create, MedicineController.Edit, MedicineController.Delete);
    private void OrdersBtns_Click(object? sender, DataGridView e) => Router(sender, e, OrderController.Create, OrderController.Edit, OrderController.Delete);

    private void Router(object? button, DataGridView dataGrid, Action<Form> createAction, Action<int, Form> editAction, Action<int, Form> DeleteAction)
    {
        if (button is not Button b) return;

        switch (b.Name)
        {
            case "AddBtn": createAction(this); break;
            case "EditBtn": editAction(Convert.ToInt32(dataGrid.CurrentRow.Cells["id"].Value), this); break;
            case "DeleteBtn": DeleteAction(Convert.ToInt32(dataGrid.CurrentRow.Cells["id"].Value), this); break;
            default: break;
        }

        _currentPage?.Refresh();
    }
    #endregion
}
