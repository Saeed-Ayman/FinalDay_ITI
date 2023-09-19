using FinalDay_ITI.Models;
using FinalDay_ITI.Requests;
using FinalDay_ITI.Views;

namespace FinalDay_ITI.Controllers;

public class AuthController
{
    public static User? User;
    private static readonly PharmacyContext _db = MainController.DB;

    public static void Login(Form parent) => MainController.SwitchToForm(parent, new Login());

    public static void Attempt(LoginRequest request)
    {
        var data = request.Validate();

        var user = _db.Users.Where(user => data.Email == user.Email).SingleOrDefault();

        if (user == null || user.Password != data.Password)
            throw new Exception("Email or password are wrong!!");

        User = user;
    }

    public static void Register(Form parent) => MainController.SwitchToForm(parent, new Register());

    public static void SignUp(UserRequest request)
    {
        UserController.Store(request);

        Attempt(new(request.User.Email, request.User.Password));
    }

    public static void Logout(Form parent)
    {
        var result = MessageBox.Show(
            "Are you sure to logout?",
            "Logout",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        );

        if (result == DialogResult.Yes) SignOut(parent);
    }

    public static void SignOut(Form parent)
    {
        User = null;
        Login(parent);
    }

    public static object History()
    {
        return OrderController.Index(order => order.UserId == User?.Id);
    }

    public static void Run(Form parent)
    {
        if (_db.Users.Any()) Login(parent);
        else Register(parent);
    }
}