using FinalDay_ITI.Controllers;
using FinalDay_ITI.Models;

namespace FinalDay_ITI.Views.User
{
    public partial class EditUser : Form
    {
        private Models.User user;

        public EditUser(Models.User user)
        {
            InitializeComponent();
            this.user = user;

            NameLabel.Text += user.Name;
            EmailLabel.Text += user.Email;

            comboBox1.DataSource = Enum.GetValues(typeof(ERole));
            comboBox1.SelectedItem = user.Role;
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                UserController.Update(user.Id, (ERole)comboBox1.SelectedItem);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
