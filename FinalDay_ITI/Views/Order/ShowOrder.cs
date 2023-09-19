using FinalDay_ITI.Controllers;

namespace FinalDay_ITI.Views.Order
{
    public partial class ShowOrder : Form
    {
        private Models.Order _order;

        public ShowOrder(Models.Order order)
        {
            InitializeComponent();

            _order = order;
            dataGridView.DataSource = _order.OrderMedicines.Index();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            OrderMedicineController.Edit(/*_order.Id*/);
            dataGridView.DataSource = _order.OrderMedicines.Index();
        }
    }
}
