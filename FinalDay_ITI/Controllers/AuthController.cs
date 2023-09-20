﻿using FinalDay_ITI.Models;
using FinalDay_ITI.Requests;
using FinalDay_ITI.Views;

namespace FinalDay_ITI.Controllers;

public class AuthController
{
    public static User? User;
    private static readonly PharmacyContext _db = MainController.DB;
    private static bool _firstUser;

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
        if (_firstUser)
        {
            request.Role = ERole.Manager;
            _firstUser = false;
        }

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
        Run(parent);
    }

    public static void Run(Form parent)
    {
        if (_firstUser = !_db.Users.Any(user => user.Role == ERole.Manager)) Register(parent);
        else Login(parent);
    }
}