using FinalDay_ITI.Models;
using FinalDay_ITI.Requests;
using FinalDay_ITI.Views.Partials;
using FinalDay_ITI.Views.User;
using Microsoft.EntityFrameworkCore;

namespace FinalDay_ITI.Controllers;

public class UserController
{
    private static readonly PharmacyContext _db = MainController.DB;

    public static object Index(Func<User, bool> predicate)
        => _db.Users.Include("Orders").Where(predicate).Select(
                user => new { user.Id, user.Name, user.Email, user.Role, OrdersNumber = user.Orders.Count }
            ).Where(user => user.Id != AuthController.User.Id).ToList();

    public static object Index() => Index(user => true);

    public static void Create(Form parent) => new AddUser().ShowDialog(parent);

    public static void Store(UserRequest request)
    {
        var newUser = request.Validate();

        if (_db.Users.Where(user => user.Email == newUser.Email).Any())
            throw new Exception("Email has already been taken.");

        _db.Users.Add(newUser);

        _db.SaveChanges();
    }

    public static void Edit(int id, Form parent)
        => new EditUser(_db.Users.Where(user => id == user.Id).ToList().Single()).ShowDialog(parent);

    public static void Update(int id, ERole role)
    {
        var user = _db.Users.Where(user => id == user.Id).ToList().Single();

        user.Role = role;

        _db.SaveChanges();
    }

    public static void Delete(int id, Form parent)
        => new DeleteUser(_db.Users.Where(user => id == user.Id).ToList().Single()).ShowDialog(parent);


    public static void Destroy(int id)
    {
        var user = _db.Users.Where(user => id == user.Id).ToList().Single();

        _db.Users.Remove(user);

        _db.SaveChanges();
    }
}

