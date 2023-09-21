using FinalDay_ITI.Controllers;

namespace FinalDay_ITI.Views;

public partial class Register : Form
{
    public Register() => InitializeComponent();

    private void LoginLabel_Click(object sender, EventArgs e) => AuthController.Login();

    private void RegisterBtn_Click(object sender, EventArgs e)
    {
        try
        {
            AuthController.SignUp(
                new(FirstNameTxt.Text, LastNameTxt.Text, EmailTxt.Text, PasswordTxt.Text, ConfirmPasswordTxt.Text)
            );

            MainController.SwitchToForm(new Dashboard());
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Register Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
