using FinalDay_ITI.Controllers;

namespace FinalDay_ITI.Views.Medicine
{
    public partial class DeleteMedicine : Form
    {
        private Models.Medicine _medicine;

        public DeleteMedicine(Models.Medicine medicine)
        {
            InitializeComponent();

            _medicine = medicine;
            MedicineLabel.Text += " " + medicine.Name;
            PriceLabel.Text += " " + medicine.Price;
            QuantityLabel.Text += " " + medicine.Quantity;
            ProductionDateLabel.Text += " " + medicine.ProductionDate.ToShortDateString();
            ExpirationDateInput.Text += " " + medicine.ExpirationDate.ToShortDateString();
            CategoryLabel.Text += " " + medicine.Category.Name;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                MedicineController.Destroy(_medicine.Id);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
