using FinalDay_ITI.Models;
using FinalDay_ITI.Repositories;
using FinalDay_ITI.Views.Order;
using Microsoft.EntityFrameworkCore;

namespace FinalDay_ITI.Controllers;

public class OrderController
{
    private static readonly PharmacyContext _db = MainController.DB;

    public static List<OrderRepository> Index(Func<Order, bool> prediction, Func<OrderRepository, bool> predict)
        => _db.Orders.Include("OrderMedicines.Medicine").Include("User").Where(prediction).Select(order => new OrderRepository
        {
            Id = order.Id,
            User = order.User.Name,
            Medicines = string.Join(", ", order.OrderMedicines.Select(orderMedicine => orderMedicine.Medicine.Name).Distinct()),
            TotalQuantity = order.OrderMedicines.Select(orderMedicine => orderMedicine.Quantity).Sum(),
            TotalPrice = order.OrderMedicines.Select(orderMedicine => orderMedicine.Quantity * orderMedicine.Medicine.Price).Sum(),
            Date = order.Date,
        }).Where(predict).ToList();

    public static List<OrderRepository> Index() => Index((Order obj) => true);
    public static List<OrderRepository> Index(Func<Order, bool> predict) => Index(predict, obj => true);
    public static List<OrderRepository> Index(Func<OrderRepository, bool> predict) => Index(obj => true, predict);

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

        foreach (var orderMedicine in order.OrderMedicines)
            OrderMedicineController.Destroy(orderMedicine.OrderId, orderMedicine.Id);

        _db.Remove(order);

        _db.SaveChanges();
    }
}
