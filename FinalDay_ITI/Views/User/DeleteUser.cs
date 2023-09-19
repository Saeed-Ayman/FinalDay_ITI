using FinalDay_ITI.Controllers;

namespace FinalDay_ITI.Views.User
{
    public partial class DeleteUser : Form
    {
        private readonly Models.User _user;

        public DeleteUser(Models.User user)
        {
            InitializeComponent();

            _user = user;
            NameLabel.Text += " " + _user.Name;
            EmailLabel.Text += " " + _user.Email;
            RoleLabel.Text += " " + _user.Role;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                UserController.Destroy(_user.Id);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
