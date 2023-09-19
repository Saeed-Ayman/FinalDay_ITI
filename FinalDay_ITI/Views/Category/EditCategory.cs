using FinalDay_ITI.Controllers;

namespace FinalDay_ITI.Views.Category;

public partial class EditCategory : Form
{
    private Models.Category _category;

    public EditCategory(Models.Category category)
    {
        InitializeComponent();
        _category = category;
        CategoryNameTxt.Text += _category.Name;
    }

    private void EditBtn_Click(object sender, EventArgs e)
    {
        try
        {
            if (_category.Name != CategoryNameTxt.Text)
                CategoryController.Update(_category.Id, CategoryNameTxt.Text);

            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error edit category", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
