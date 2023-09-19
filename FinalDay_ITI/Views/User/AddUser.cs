using FinalDay_ITI.Controllers;
using FinalDay_ITI.Models;

namespace FinalDay_ITI.Views.Partials
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
            RoleNames.DataSource = Enum.GetValues(typeof(ERole));
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                UserController.Store(
                    new(FirstNameTxt.Text, LastNameTxt.Text, EmailTxt.Text, PasswordTxt.Text, ConfirmPasswordTxt.Text, (ERole)RoleNames.SelectedItem)
                );
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error add user", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
