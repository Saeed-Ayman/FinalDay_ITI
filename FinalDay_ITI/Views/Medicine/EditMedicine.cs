using FinalDay_ITI.Controllers;

namespace FinalDay_ITI.Views.Medicine
{
    public partial class EditMedicine : Form
    {
        private readonly Models.Medicine _medicine;

        public EditMedicine(Models.Medicine medicine)
        {
            InitializeComponent();

            _medicine = medicine;
            MedicineNameTxt.Text = _medicine.Name;
            PriceInput.Value = ((decimal)_medicine.Price);
            QuantityInput.Value = _medicine.Quantity;
            ProductionDate.Value = _medicine.ProductionDate;
            ProductionDate.MaxDate = DateTime.Now;
            ExpirationDate.Value = _medicine.ExpirationDate;

            CategoryNames.DataSource = CategoryController.Index();
            CategoryNames.DisplayMember = "Name";
            CategoryNames.ValueMember = "Id";
            CategoryNames.SelectedValue = _medicine.CategoryId;
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                MedicineController.Update(_medicine.Id, new(
                    MedicineNameTxt.Text,
                    ((double)PriceInput.Value),
                    (int)QuantityInput.Value,
                    ProductionDate.Value,
                    ExpirationDate.Value,
                    Convert.ToInt32(CategoryNames.SelectedValue)
                ));

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Edit Medicine", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ProductionDate_ValueChanged(object sender, EventArgs e) => ExpirationDate.MinDate = ProductionDate.Value;
        private void ExpirationDate_ValueChanged(object sender, EventArgs e) => ProductionDate.MaxDate = ExpirationDate.Value;
    }
}
