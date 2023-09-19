using FinalDay_ITI.Models;
using FinalDay_ITI.Views;
using FinalDay_ITI.Views.Order;
using Microsoft.EntityFrameworkCore;

namespace FinalDay_ITI.Controllers;

public class OrderController
{
    private static readonly PharmacyContext _db = MainController.DB;

    public static object Index(Func<Order, bool> prediction)
    {
        return _db.Orders.
            Include("OrderMedicines.Medicine").Where(prediction).Select(order => new
            {
                order.Id,
                order.User.Name,
                Medicines = string.Join(", ", order.OrderMedicines.Select(
                    orderMedicine => orderMedicine.Medicine.Name
                ).Distinct()),
                TotalQuantity = order.OrderMedicines.Select(orderMedicine => orderMedicine.Quantity).Sum(),
                TotalPrice = order.OrderMedicines.Select(
                    orderMedicine => orderMedicine.Quantity * orderMedicine.Medicine.Price
                ).Sum(),
                order.Date,
            }).ToList();
    }
    public static object Index()
    {
        return Index(obj => true);
    }

    public static void Create(Dashboard parent)
    {
        parent.navSideBar1.CreateOrderBtn.PerformClick();
    }

    public static void Store(List<OrderMedicine> orderMedicines)
    {
        // TODO : Make Validation
        _db.Orders.Add(new()
        {
            OrderMedicines = orderMedicines,
            Date = DateTime.Now,
            UserId = AuthController.User.Id
        });

        _db.SaveChanges();
    }

    public static void Show(int id, Form parent)
    {
        var order = _db.Orders.Where(order => id == order.Id).ToList().Single();

        new ShowOrder(order).ShowDialog(parent);
    }

    //// TODO : set a fucking role
    //public static void Update(int id, ERole role)
    //{
    //    _db.Orders ??= _db.Orders;

    //    var order = _db.Orders.Where(order => id == order.Id).ToList().Single();

    //    order.Role = role;

    //    _db.SaveChanges();
    //}

    //public static void Destroy(int id)
    //{
    //    _db.Orders ??= _db.Orders;

    //    var order = _db.Orders.Where(order => id == order.Id).ToList().Single();

    //    _db.Orders.Remove(order);

    //    _db.SaveChanges();
    //}
}
