using FinalDay_ITI.Controllers;

namespace FinalDay_ITI.Views.Medicine
{
    public partial class AddMedicine : Form
    {
        public AddMedicine()
        {
            InitializeComponent();
            comboBox1.DataSource = CategoryController.Index();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            MedicineController.Store(
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
