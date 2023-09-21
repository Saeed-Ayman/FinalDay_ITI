using FinalDay_ITI.Controllers;

namespace FinalDay_ITI.Views.Partials;

public partial class DashboardHeader : UserControl
{
    public event EventHandler<EventArgs>? OnClickMenuBtn;

    public DashboardHeader()
    {
        InitializeComponent();
        Refresh();
    }

    private void MenuBtn_Click(object sender, EventArgs e) => OnClickMenuBtn?.Invoke(sender, e);

    private void LogoutBtn_Click(object sender, EventArgs e) => AuthController.Logout();

    public override void Refresh()
    {
        base.Refresh();
        UsernameLabel.Text = AuthController.User.Name + $"({AuthController.User.Role})";
    }
}
