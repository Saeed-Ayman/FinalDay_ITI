using System.Text.RegularExpressions;

namespace FinalDay_ITI.Requests;

public static class Validator
{
    public static bool IsEmpty(this string str) => str.Length == 0;

    public static bool Min(this string str, int number) => str.Length >= number;

    public static string ToUFirst(this string str) => str[..1].ToUpper() + str[1..].ToLower();

    public static bool IsValidEmail(this string str)
        => new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}").IsMatch(str);
}
