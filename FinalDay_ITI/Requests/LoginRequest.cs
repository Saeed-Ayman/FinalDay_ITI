using FinalDay_ITI.Models;

namespace FinalDay_ITI.Requests;

public class LoginRequest
{
    private string _email;
    private string _password;

    public LoginRequest(string email, string password)
    {
        _email = email;
        _password = password;
    }

    public User Validate()
    {
        _email = _email.Trim().ToLower();

        if (_email.Length == 0 || _password.Length == 0)
            throw new Exception("Please fill all fields.");

        return new() { Email = _email, Password = _password };
    }
}
