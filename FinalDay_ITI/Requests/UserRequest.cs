using FinalDay_ITI.Models;

namespace FinalDay_ITI.Requests;

public class UserRequest
{
    private string _firstName;
    private string _lastName;
    private string _email;
    private readonly string _password;
    private readonly string _confirmedPassword;
    private readonly ERole _role;

    public User? User;

    public UserRequest(
        string firstName, string lastName, string email, string password, string confirmedPassword, ERole role = ERole.User)
    {
        _firstName = firstName;
        _lastName = lastName;
        _email = email;
        _password = password;
        _confirmedPassword = confirmedPassword;
        _role = role;
    }

    public User Validate()
    {
        _firstName = _firstName.Trim();
        _lastName = _lastName.Trim();
        _email = _email.Trim();

        if (_firstName.IsEmpty() || _lastName.IsEmpty() || _email.IsEmpty() || _password.IsEmpty() || _confirmedPassword.IsEmpty())
            throw new("Fill all fields please.");

        if (!_firstName.Min(3)) throw new("FirstName is too small.");
        if (!_lastName.Min(3)) throw new("LastName is too small.");
        if (!_email.IsValidEmail()) throw new("Email is not valid.");
        if (!_password.Min(8)) throw new("Password must be at least 8 character.");
        if (_password != _confirmedPassword) throw new("Password must match the confirmation password.");

        return User = new()
        {
            Name = _firstName.ToUFirst() + " " + _lastName.ToUFirst(),
            Email = _email.ToLower(),
            Password = _password,
            Role = _role
        };
    }
}
