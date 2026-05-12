// ============================================
// Program #29 — RandomPassword
// Category  : 03_Intermediate
// Difficulty: Intermediate
// Description: Generate a random password using letters, numbers, and symbols
// ============================================

using System;

namespace CSharp30Programs.Intermediate
{
    class Program_29_RandomPassword
    {
        static void Main(string[] args)
        {
            string characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$";
            int length = 10;
            Random random = new Random();

            char[] password = new char[length];
            for (int i = 0; i < length; i++)
            {
                password[i] = characters[random.Next(characters.Length)];
            }

            Console.WriteLine($"Generated password: {new string(password)}");
        }
    }
}
