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
            ExpirationDate.Value = _medicine.ExpirationDate;

            comboBox1.DataSource = CategoryController.Index();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";
            comboBox1.SelectedValue = _medicine.CategoryId;
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            MedicineController.Update(
                _medicine.Id,
                MedicineNameTxt.Text,
                ((double)PriceInput.Value),
                (int)QuantityInput.Value,
                ProductionDate.Value,
                ExpirationDate.Value,
                comboBox1.SelectedValue == null ? 0 : (int)comboBox1.SelectedValue
            );

            Close();
        }
    }
}
