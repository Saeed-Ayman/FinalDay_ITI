using FinalDay_ITI.Controllers;

namespace FinalDay_ITI.Views.Partials;

public partial class DashboardHeader : UserControl
{
    public event EventHandler<EventArgs>? OnClickMenuBtn;

    public DashboardHeader() => InitializeComponent();

    private void MenuBtn_Click(object sender, EventArgs e) => OnClickMenuBtn?.Invoke(sender, e);

    private void LogoutBtn_Click(object sender, EventArgs e) => AuthController.Logout(ParentForm);
}
