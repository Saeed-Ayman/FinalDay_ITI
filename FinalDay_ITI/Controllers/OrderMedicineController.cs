using FinalDay_ITI.Models;
using FinalDay_ITI.Views.Order;

namespace FinalDay_ITI.Controllers;

public static class OrderMedicineController
{
    private static PharmacyContext _db = MainController.DB;

    public static object Index(this ICollection<OrderMedicine> orderMedicines)
    {
        return orderMedicines.Join(
            _db.Medicines,
            orderMedicine => orderMedicine.MedicineId,
            medicine => medicine.Id,
            (orderMedicine, medicine) => new
            {
                Medicine = medicine.Name,
                orderMedicine.Quantity,
                TotalPrice = medicine.Price * orderMedicine.Quantity
            }
        ).ToList();
    }

    public static void Edit(OrderMedicine orderMedicine, Form parent)
        => new EditOrderMedicines(orderMedicine).ShowDialog(parent);

    public static void Update(OrderMedicine editedOrderMedicine)
    {
        var order = _db.Orders.Where(order => order.Id == editedOrderMedicine.OrderId).First();
        var orderMedicine = order.OrderMedicines.Where(orderMedicine => orderMedicine.Id == editedOrderMedicine.Id).First();
        var orderSameMedicine = order.OrderMedicines.
            Where(orderMedicine => orderMedicine.MedicineId == editedOrderMedicine.MedicineId).FirstOrDefault();

        if (orderSameMedicine == null)
        {
            orderMedicine.MedicineId = editedOrderMedicine.MedicineId;
            orderMedicine.Quantity = editedOrderMedicine.Quantity;
        }
        else
        {
            orderSameMedicine.Quantity += editedOrderMedicine.Quantity;
            order.OrderMedicines.Remove(orderMedicine);
        }

        _db.SaveChanges();
    }


    //private static PharmacyContext _db = MainController.DB;

    //public static void Store(Order order, int medicineId, int quantity)
    //{
    //    order.Medicines.Add(new()
    //    {
    //        OrderId = order.Id,
    //        MedicineId = medicineId,
    //        Quantity = quantity
    //    });

    //    _db.SaveChanges();
    //}

    //public static void Destroy(Order order, int orderMedicineId)
    //{
    //    var orderMedicine = _db.OrderMedicines.Where(orderMedicine => orderMedicine.Id == orderMedicineId).Single();

    //    order.Medicines.Remove(orderMedicine);

    //    _db.SaveChanges();
    //}
}
