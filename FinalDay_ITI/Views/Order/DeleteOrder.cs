using FinalDay_ITI.Controllers;

namespace FinalDay_ITI.Views.Order;

public partial class DeleteOrder : Form
{
    private Models.Order _order;
    public DeleteOrder(Models.Order order)
    {
        InitializeComponent();

        _order = order;
        dataGridView.DataSource = _order.Index();
    }

    private void DeleteBtn_Click(object sender, EventArgs e)
    {
        try
        {
            OrderController.Destroy(_order.Id);
            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Something Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
