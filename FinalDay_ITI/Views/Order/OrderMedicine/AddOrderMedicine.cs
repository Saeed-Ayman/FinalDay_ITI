using FinalDay_ITI.Controllers;

namespace FinalDay_ITI.Views.Order;

public partial class AddOrderMedicine : Form
{
    private Models.Order _order;

    public AddOrderMedicine(Models.Order order)
    {
        InitializeComponent();

        _order = order;
        MedicineNames.DataSource = MedicineController.Index();
        MedicineNames.DisplayMember = "Medicine";
        MedicineNames.ValueMember = "Id";
    }

    private void AddBtn_Click(object sender, EventArgs e)
    {
        try
        {
            OrderMedicineController.Store(_order, Convert.ToInt32(MedicineNames.SelectedValue), ((int)QuantityInput.Value));
            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error Add Order Medicine", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
