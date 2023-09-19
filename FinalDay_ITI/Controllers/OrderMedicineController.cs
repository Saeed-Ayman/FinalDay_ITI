using FinalDay_ITI.Models;
using FinalDay_ITI.Views.Order;
using FinalDay_ITI.Views.Order.OrderMedicine;

namespace FinalDay_ITI.Controllers;

public static class OrderMedicineController
{
    private static PharmacyContext _db = MainController.DB;

    public static object Index(this Order order)
    {
        return order.OrderMedicines.Join(
            _db.Medicines,
            orderMedicine => orderMedicine.MedicineId,
            medicine => medicine.Id,
            (orderMedicine, medicine) => new
            {
                orderMedicine.Id,
                Medicine = medicine.Name,
                orderMedicine.Quantity,
                TotalPrice = medicine.Price * orderMedicine.Quantity
            }
        ).ToList();
    }

    public static void Create(Order order, Form parent)
        => new AddOrderMedicine(order).ShowDialog(parent);

    public static void Store(Order order, int medicineId, int quantity)
    {
        var orderMedicines = order.OrderMedicines.Where(orderMedicine => orderMedicine.MedicineId == medicineId).FirstOrDefault();

        if (orderMedicines == null)
        {
            orderMedicines = new OrderMedicine() { MedicineId = medicineId };
            order.OrderMedicines.Add(orderMedicines);
        }

        orderMedicines.Quantity += quantity;

        _db.SaveChanges();
    }

    public static void Edit(Order order, int id, Form parent)
        => new EditOrderMedicine(order.OrderMedicines.Where(orderMedicine => orderMedicine.Id == id).First()).ShowDialog(parent);

    public static void Update(int orderId, int id, int medicineId, int quantity)
    {
        var order = _db.Orders.Where(order => order.Id == orderId).First();
        var orderMedicine = order.OrderMedicines.Where(orderMedicine => orderMedicine.Id == id).First();
        var orderSameMedicine = order.OrderMedicines.
            Where(orderMedicine => orderMedicine.MedicineId == medicineId).FirstOrDefault();

        if (orderSameMedicine == null)
        {
            orderMedicine.MedicineId = medicineId;
            orderMedicine.Quantity = quantity;
        }
        else
        {
            orderSameMedicine.Quantity += quantity;
            order.OrderMedicines.Remove(orderMedicine);
        }

        _db.SaveChanges();
    }

    public static void Delete(Order order, int id, Form parent)
        => new DeleteOrderMedicine(order.OrderMedicines.Where(order => order.Id == id).First()).ShowDialog(parent);

    public static void Destroy(int orderId, int id)
    {
        var order = _db.Orders.Where(order => order.Id == orderId).First();
        var orderMedicine = order.OrderMedicines.Where(orderMedicine => orderMedicine.Id == id).First();

        order.OrderMedicines.Remove(orderMedicine);

        _db.SaveChanges();
    }
}
