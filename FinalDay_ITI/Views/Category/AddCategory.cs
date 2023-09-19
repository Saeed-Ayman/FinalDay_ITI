using FinalDay_ITI.Controllers;

namespace FinalDay_ITI.Views.Category
{
    public partial class AddCategory : Form
    {
        public AddCategory()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                CategoryController.Store(CategoryNameTxt.Text);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error add category", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
