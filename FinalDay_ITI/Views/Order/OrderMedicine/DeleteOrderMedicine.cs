using FinalDay_ITI.Controllers;

namespace FinalDay_ITI.Views.Order.OrderMedicine
{
    public partial class DeleteOrderMedicine : Form
    {
        private Models.OrderMedicine _orderMedicine;

        public DeleteOrderMedicine(Models.OrderMedicine orderMedicine)
        {
            InitializeComponent();

            _orderMedicine = orderMedicine;
            MedicineLabel.Text += " " + _orderMedicine.Medicine.Name;
            QuantityLabel.Text += " " + _orderMedicine.Quantity;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OrderMedicineController.Destroy(_orderMedicine.OrderId, _orderMedicine.Id);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
