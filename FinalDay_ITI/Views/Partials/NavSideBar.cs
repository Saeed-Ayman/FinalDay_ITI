using FinalDay_ITI.Controllers;
using FinalDay_ITI.Models;

namespace FinalDay_ITI.Views.Partials;

public partial class NavSideBar : UserControl
{
    private Button _clicked;
    public event EventHandler<EventArgs>? OnClickBtn;

    public NavSideBar()
    {
        InitializeComponent();

        _clicked = HomeBtn;

        var role = AuthController.User.Role;

        UsersBtn.Visible = ERole.Manager <= role;
        OrdersBtn.Visible = ERole.Manager <= role;

        CategoriesBtn.Visible = ERole.Employee <= role;
        MedicinesBtn.Visible = ERole.Employee <= role;

        // just in case
        SettingsBtn.Visible = ERole.User <= role;
        HistoryBtn.Visible = ERole.User <= role;
        CreateOrderBtn.Visible = ERole.User <= role;
    }

    private void Btn_Click(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        if (button.Name == _clicked.Name) return;

        _clicked.BackColor = Color.Indigo;
        button.BackColor = Color.BlueViolet;
        _clicked = button;

        OnClickBtn?.Invoke(sender, e);
    }

    public void ShowOrHidePanel(object? sender, EventArgs e) => Visible = !Visible;
}
