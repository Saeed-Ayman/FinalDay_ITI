using FinalDay_ITI.Models;
using FinalDay_ITI.Requests;

namespace FinalDay_ITI.Controllers;

public class SettingsController
{
    private static PharmacyContext _db = MainController.DB;

    public static void UpdateInfo(UserRequest request)
    {
        User edited = request.Validate();
        var user = AuthController.User;

        if (user.Password != edited.Password)
            throw new Exception("Password is wrong.");

        if (user.Email != edited.Email && _db.Users.Where(user => user.Email == edited.Email).Any())
            throw new Exception("Email has been taken.");

        user.Name = edited.Name;
        user.Email = edited.Email;

        _db.SaveChanges();
    }

    public static void UpdatePassword(string oldPassword, string password, string confirmedPassword)
    {
        User user = AuthController.User;

        if (user.Password != oldPassword)
            throw new Exception("Password is wrong.");

        if (password != confirmedPassword)
            throw new Exception("Password must match the confirmation password.");

        user.Password = password;

        _db.SaveChanges();
    }

    public static void Destroy(string password)
    {
        var User = AuthController.User;

        if (User.Password != password)
            throw new Exception("Wrong password");

        _db.Remove(User);

        _db.SaveChanges();
    }
}
