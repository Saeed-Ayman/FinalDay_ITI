using FinalDay_ITI.Controllers;

namespace FinalDay_ITI.Views.Order;

public partial class EditOrderMedicines : Form
{
    private Models.OrderMedicine _orderMedicine;

    public EditOrderMedicines(Models.OrderMedicine orderMedicine)
    {
        InitializeComponent();

        _orderMedicine = orderMedicine;

        MedicineNames.DataSource = MedicineController.Index();
        MedicineNames.DisplayMember = "Name";
        MedicineNames.ValueMember = "Id";

        MedicineNames.SelectedValue = _orderMedicine.Id;
        QuantityInput.Value = _orderMedicine.Quantity;
    }

    private void EditBtn_Click(object sender, EventArgs e)
    {
        try
        {
            _orderMedicine.Quantity = (int)QuantityInput.Value;
            _orderMedicine.MedicineId = (int)MedicineNames.SelectedValue;
            OrderMedicineController.Update(_orderMedicine);
            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error edit order", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
