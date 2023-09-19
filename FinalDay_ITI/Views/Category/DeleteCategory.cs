using FinalDay_ITI.Controllers;

namespace FinalDay_ITI.Views.Category;

public partial class DeleteCategory : Form
{
    private Models.Category _category;

    public DeleteCategory(Models.Category category)
    {
        InitializeComponent();

        _category = category;
        CategoryLabel.Text += " " + _category.Name;
    }

    private void DeleteBtn_Click(object sender, EventArgs e)
    {
        try
        {
            CategoryController.Destroy(_category.Id);
            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Something wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
