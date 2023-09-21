using FinalDay_ITI.Models;
using FinalDay_ITI.Repositories;
using FinalDay_ITI.Views.Order;
using FinalDay_ITI.Views.Order.OrderMedicine;

namespace FinalDay_ITI.Controllers;

public static class OrderMedicineController
{
    private static PharmacyContext _db = MainController.DB;

    public static object Index(this Order order, Func<OrderMedicineRepository, bool> predicate)
        => order.OrderMedicines.Join(
            _db.Medicines,
            orderMedicine => orderMedicine.MedicineId,
            medicine => medicine.Id,
            (orderMedicine, medicine) => new OrderMedicineRepository
            {
                Id = orderMedicine.Id,
                Medicine = medicine.Name,
                Quantity = orderMedicine.Quantity,
                TotalPrice = medicine.Price * orderMedicine.Quantity
            }
        ).Where(predicate).ToList();

    public static object Index(this Order order) => Index(order, obj => true);

    public static void Create(Order order, Form parent)
        => new AddOrderMedicine(order).ShowDialog(parent);

    public static void Store(Order order, int medicineId, int quantity)
    {
        var medicine = _db.Medicines.Where(medicine => medicine.Id == medicineId).First();

        if (quantity > medicine.Quantity)
            throw new Exception($"Quantity not available.\n\rMedicine quantity = {medicine.Quantity}.");

        medicine.Quantity -= quantity;

        var orderSameMedicines = order.OrderMedicines.Where(orderMedicine => orderMedicine.MedicineId == medicineId).FirstOrDefault();

        if (orderSameMedicines == null)
        {
            orderSameMedicines = new OrderMedicine() { MedicineId = medicineId };
            order.OrderMedicines.Add(orderSameMedicines);
        }

        orderSameMedicines.Quantity += quantity;

        _db.SaveChanges();
    }

    public static void Edit(Order order, int id, Form parent)
        => new EditOrderMedicine(order.OrderMedicines.Where(orderMedicine => orderMedicine.Id == id).First()).ShowDialog(parent);

    public static void Update(int orderId, int id, int medicineId, int quantity)
    {
        var order = _db.Orders.Where(order => order.Id == orderId).First();
        var orderMedicine = order.OrderMedicines.Where(orderMedicine => orderMedicine.Id == id).First();

        if (orderMedicine.MedicineId != medicineId)
        {
            var newMedicine = _db.Medicines.Where(medicine => medicine.Id == medicineId).First();

            if (newMedicine.Quantity < quantity)
                throw new Exception($"Quantity not available.\n\rMedicine quantity = {newMedicine.Quantity}.");

            orderMedicine.Medicine.Quantity += orderMedicine.Quantity;
            newMedicine.Quantity -= quantity;

            orderMedicine.MedicineId = newMedicine.Id;
            orderMedicine.Quantity += quantity;
        }
        else
        {
            if (orderMedicine.Medicine.Quantity + orderMedicine.Quantity < quantity)
                throw new Exception($"Quantity not available.\n\rMedicine quantity = {orderMedicine.Medicine.Quantity + orderMedicine.Quantity}.");

            orderMedicine.Medicine.Quantity += orderMedicine.Quantity - quantity;
            orderMedicine.Quantity = quantity;
        }


        var orderSameMedicine = order.OrderMedicines.
            Where(orderMedicine => orderMedicine.Id != id && orderMedicine.MedicineId == medicineId).FirstOrDefault();

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

        orderMedicine.Medicine.Quantity += orderMedicine.Quantity;

        order.OrderMedicines.Remove(orderMedicine);

        _db.SaveChanges();
    }
}
