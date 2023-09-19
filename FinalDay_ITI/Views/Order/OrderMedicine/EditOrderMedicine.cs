using FinalDay_ITI.Controllers;

namespace FinalDay_ITI.Views.Order;

public partial class EditOrderMedicine : Form
{
    private Models.OrderMedicine _orderMedicine;

    public EditOrderMedicine(Models.OrderMedicine orderMedicine)
    {
        InitializeComponent();

        _orderMedicine = orderMedicine;

        MedicineNames.DataSource = MedicineController.Index();
        MedicineNames.DisplayMember = "Name";
        MedicineNames.ValueMember = "Id";

        MedicineNames.SelectedValue = _orderMedicine.Medicine.Id;
        QuantityInput.Value = _orderMedicine.Quantity;
    }

    private void EditBtn_Click(object sender, EventArgs e)
    {
        try
        {
            OrderMedicineController.Update(
                 _orderMedicine.OrderId,
                 _orderMedicine.Id,
                Convert.ToInt32(MedicineNames.SelectedValue),
                (int)QuantityInput.Value
            );
            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error edit order", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
