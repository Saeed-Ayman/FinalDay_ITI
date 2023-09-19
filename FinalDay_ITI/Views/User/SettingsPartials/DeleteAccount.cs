using FinalDay_ITI.Controllers;

namespace FinalDay_ITI.Views.User.SettingsPartials;

public partial class DeleteAccount : UserControl
{
    public DeleteAccount()
    {
        InitializeComponent();
    }

    private void DeleteBtn_Click(object sender, EventArgs e)
    {
        var result = MessageBox.Show(
            "Are you sure to remove the account?",
            "Delete Account",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        );

        if (result != DialogResult.Yes)
        {
            PasswordTxt.Text = string.Empty;
            return;
        }

        try
        {
            SettingsController.Destroy(PasswordTxt.Text);
            AuthController.SignOut(ParentForm);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error Delete Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Refresh();
        }
    }

    public override void Refresh()
    {
        base.Refresh();
        PasswordTxt.Text = "";
    }
}
