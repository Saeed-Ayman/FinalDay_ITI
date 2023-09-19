using FinalDay_ITI.Controllers;

namespace FinalDay_ITI.Views.Order
{
    public partial class AddOrdera : UserControl
    {
        List<Models.OrderMedicine> orderMedicines;

        public AddOrdera()
        {
            InitializeComponent();

            MedicineNames.DataSource = MedicineController.Index();
            MedicineNames.ValueMember = "Id";
            MedicineNames.DisplayMember = "Name";

            orderMedicines = new();
            dataGridView.DataSource = orderMedicines.Index();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            orderMedicines.Add(new()
            {
                MedicineId = Convert.ToInt32(MedicineNames.SelectedValue),
                Quantity = ((int)QuantityInput.Value)
            });

            dataGridView.DataSource = orderMedicines.Index();
            Clear();
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            orderMedicines.RemoveAt(dataGridView.CurrentRow.Index);
            dataGridView.DataSource = orderMedicines.Index();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            OrderController.Store(orderMedicines);
            Refresh();
        }

        private void Clear()
        {
            QuantityInput.Value = 0;
            if (MedicineNames.Items.Count != 0) MedicineNames.SelectedIndex = 0;
        }

        public override void Refresh()
        {
            base.Refresh();

            MedicineNames.DataSource = MedicineController.Index();
            MedicineNames.ValueMember = "Id";
            MedicineNames.DisplayMember = "Name";

            orderMedicines = new();
            dataGridView.DataSource = orderMedicines.Index();

            Clear();
        }

        private void DataGridView_DataSourceChanged(object sender, EventArgs e)
        {
            RemoveBtn.Enabled = dataGridView.RowCount > 0;
        }
    }
}
