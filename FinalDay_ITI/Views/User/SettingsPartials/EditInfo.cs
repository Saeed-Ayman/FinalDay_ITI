using FinalDay_ITI.Controllers;

namespace FinalDay_ITI.Views.User.SettingsPartials;

public partial class EditInfo : UserControl
{
    public event Action? OnRefresh;

    public EditInfo()
    {
        InitializeComponent();
        Refresh();
    }

    private void EditBtn_Click(object sender, EventArgs e)
    {
        try
        {
            SettingsController.UpdateInfo(new(FirstNameTxt.Text, LastNameTxt.Text, EmailTxt.Text, PasswordTxt.Text, PasswordTxt.Text));
            MessageBox.Show("Update info successfully.", "Edit info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Refresh();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error Edit Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public override void Refresh()
    {
        base.Refresh();

        var _user = AuthController.User;

        var name = _user.Name.Split(' ');

        FirstNameTxt.Text = name[0];
        LastNameTxt.Text = name[1];
        EmailTxt.Text = _user.Email;
        PasswordTxt.Text = "";

        OnRefresh?.Invoke();
    }
}
