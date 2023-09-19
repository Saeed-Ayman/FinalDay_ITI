using FinalDay_ITI.Controllers;

namespace FinalDay_ITI.Views.User.SettingsPartials;

public partial class EditPassword : UserControl
{
    public EditPassword()
    {
        InitializeComponent();
    }

    private void EditBtn_Click(object sender, EventArgs e)
    {
        try
        {
            SettingsController.UpdatePassword(OldPasswordTxt.Text, PasswordTxt.Text, ConfirmPasswordTxt.Text);
            MessageBox.Show("Password update successfully.", "Edit Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Refresh();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error Edit Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public override void Refresh()
    {
        base.Refresh();

        OldPasswordTxt.Text = "";
        PasswordTxt.Text = "";
        ConfirmPasswordTxt.Text = "";
    }
}
