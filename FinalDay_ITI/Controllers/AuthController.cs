using FinalDay_ITI.Models;
using FinalDay_ITI.Requests;
using FinalDay_ITI.Views;

namespace FinalDay_ITI.Controllers;

public class AuthController
{
    public static User? User;
    private static readonly PharmacyContext _db = MainController.DB;
    private static bool _firstUser;

    public static void Login() => MainController.SwitchToForm(new Login());

    public static void Attempt(LoginRequest request)
    {
        var data = request.Validate();

        var user = _db.Users.Where(user => data.Email == user.Email).SingleOrDefault();

        if (user == null || user.Password != data.Password)
            throw new Exception("Email or password are wrong!!");

        User = user;
    }

    public static void Register() => MainController.SwitchToForm(new Register());

    public static void SignUp(UserRequest request)
    {
        if (_firstUser)
        {
            request.Role = ERole.Manager;
            _firstUser = false;
        }

        UserController.Store(request);

        Attempt(new(request.User.Email, request.User.Password));
    }

    public static void Logout()
    {
        var result = MessageBox.Show(
            "Are you sure to logout?",
            "Logout",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        );

        if (result == DialogResult.Yes) SignOut();
    }

    public static void SignOut()
    {
        User = null;
        Run();
    }

    public static void Run()
    {
        if (_firstUser = !_db.Users.Any(user => user.Role == ERole.Manager)) Register();
        else Login();
    }
}