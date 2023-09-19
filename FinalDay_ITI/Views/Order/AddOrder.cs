using FinalDay_ITI.Controllers;
using FinalDay_ITI.Views.Partials;

namespace FinalDay_ITI.Views.Order
{
    public partial class AddOrder : Form
    {
        private GridViewPage gridViewPage;
        private Models.Order _order;

        public AddOrder()
        {
            InitializeComponent();

            _order = new() { UserId = AuthController.User.Id, OrderMedicines = new List<Models.OrderMedicine>(), Date = DateTime.Now };
            OrderController.Store(_order);

            gridViewPage = new(_order.Index) { Dock = DockStyle.Fill };
            gridViewPage.OnClickBtns += ClickBtns;
            Controls.Add(gridViewPage);
        }

        private void ClickBtns(object? sender, DataGridView e)
        {
            if (sender is not Button b) return;

            switch (b.Name)
            {
                case "AddBtn":
                    OrderMedicineController.Create(_order, this);
                    break;
                case "EditBtn":
                    OrderMedicineController.Edit(_order, Convert.ToInt32(e.CurrentRow.Cells["id"].Value), this);
                    break;
                case "DeleteBtn":
                    OrderMedicineController.Delete(_order, Convert.ToInt32(e.CurrentRow.Cells["id"].Value), this);
                    break;
                default:
                    break;
            }

            gridViewPage.Refresh();
        }
    }
}
