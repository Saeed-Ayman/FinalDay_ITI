using FinalDay_ITI.Models;
using FinalDay_ITI.Views.Order;
using Microsoft.EntityFrameworkCore;

namespace FinalDay_ITI.Controllers;

public class OrderController
{
    private static readonly PharmacyContext _db = MainController.DB;

    public static object Index(Func<Order, bool> prediction)
        => _db.Orders.Include("OrderMedicines.Medicine").Where(prediction).Select(order => new
        {
            order.Id,
            order.User.Name,
            Medicines = string.Join(", ", order.OrderMedicines.Select(orderMedicine => orderMedicine.Medicine.Name).Distinct()),
            TotalQuantity = order.OrderMedicines.Select(orderMedicine => orderMedicine.Quantity).Sum(),
            TotalPrice = order.OrderMedicines.Select(orderMedicine => orderMedicine.Quantity * orderMedicine.Medicine.Price).Sum(),
            order.Date,
        }).ToList();

    public static object Index() => Index(obj => true);

    public static void Create(Form parent) => new AddOrder().ShowDialog(parent);

    public static void Store(Order order)
    {
        _db.Orders.Add(order);
        _db.SaveChanges();
    }

    public static void Edit(int id, Form parent)
        => new EditOrder(_db.Orders.Where(order => order.Id == id).First()).ShowDialog(parent);

    public static void Delete(int id, Form parent)
        => new DeleteOrder(_db.Orders.Where(order => order.Id == id).First()).ShowDialog(parent);

    public static void Destroy(int id)
    {
        var order = _db.Orders.Where(order => order.Id == id).First();

        _db.Remove(order);

        _db.SaveChanges();
    }
}
