// Program to validate email format
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string email = "user@example.com";
        if (IsValidEmail(email))
            Console.WriteLine("Valid email");
        else
            Console.WriteLine("Invalid email");
    }

    static bool IsValidEmail(string email)
    {
        string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
        return Regex.IsMatch(email, pattern);
    }
}
