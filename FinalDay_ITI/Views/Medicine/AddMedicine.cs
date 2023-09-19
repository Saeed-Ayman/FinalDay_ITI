using FinalDay_ITI.Controllers;

namespace FinalDay_ITI.Views.Medicine
{
    public partial class AddMedicine : Form
    {
        public AddMedicine()
        {
            InitializeComponent();
            CategoryNames.DataSource = CategoryController.Index();
            CategoryNames.DisplayMember = "Name";
            CategoryNames.ValueMember = "Id";

            ProductionDate.MaxDate = DateTime.Now;
            ExpirationDate.MinDate = DateTime.Now.AddDays(1);
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                MedicineController.Store(new(
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
                MessageBox.Show(ex.Message, "Error add medicine", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ProductionDate_ValueChanged(object sender, EventArgs e) => ExpirationDate.MinDate = ProductionDate.Value.AddDays(1);
        private void ExpirationDate_ValueChanged(object sender, EventArgs e) => ProductionDate.MaxDate = ExpirationDate.Value.AddDays(-1);
    }
}
