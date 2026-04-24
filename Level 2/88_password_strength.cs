// Program to validate password strength
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string password = "MySecurePassword123!";
        if (IsStrongPassword(password))
            Console.WriteLine("Strong password");
        else
            Console.WriteLine("Weak password");
    }

    static bool IsStrongPassword(string password)
    {
        // Check if password is at least 8 characters long
        if (password.Length < 8)
            return false;

        // Check if password contains at least one uppercase letter
        if (!Regex.IsMatch(password, @"[A-Z]"))
            return false;

        // Check if password contains at least one lowercase letter
        if (!Regex.IsMatch(password, @"[a-z]"))
            return false;

        // Check if password contains at least one digit
        if (!Regex.IsMatch(password, @"[0-9]"))
            return false;

        // Check if password contains at least one special character
        if (!Regex.IsMatch(password, @"[!@#$%^&*()-+]"))
            return false;

        return true;
    }
}
