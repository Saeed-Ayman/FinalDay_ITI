using FinalDay_ITI.Repositories;

namespace FinalDay_ITI.Controllers;

public class UserOrderController
{
    public static List<OrderRepository> Index()
        => OrderController.Index(order => order.UserId == AuthController.User?.Id);
    public static List<OrderRepository> Index(Func<OrderRepository, bool> predict)
        => OrderController.Index(order => order.UserId == AuthController.User?.Id, predict);
}
