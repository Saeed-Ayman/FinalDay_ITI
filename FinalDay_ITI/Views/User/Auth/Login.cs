using FinalDay_ITI.Controllers;

namespace FinalDay_ITI.Views;

public partial class Login : Form
{
    public Login() => InitializeComponent();

    private void RegisterLabel_Click(object sender, EventArgs e) => AuthController.Register(this);

    private void LoginBtn_Click(object sender, EventArgs e)
    {
        try
        {
            AuthController.Attempt(new(EmailTxt.Text, PasswordTxt.Text));
            MainController.SwitchToForm(this, new Dashboard());
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
