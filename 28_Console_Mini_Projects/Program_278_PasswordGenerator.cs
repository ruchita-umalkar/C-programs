// ============================================
// Program #278 — PasswordGenerator
// Category  : 28_Console_Mini_Projects
// Difficulty: [Intermediate]
// Description: Random password generator with strength levels.
// ============================================

using System;

namespace CSharp30Programs.ConsoleMiniProjects
{
    class Program_278_PasswordGenerator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Password Generator");
            while (true)
            {
                Console.WriteLine("\nSelect strength: 1.Weak 2.Medium 3.Strong 4.Exit");
                Console.Write("Choose: ");
                string choice = (Console.ReadLine() ?? "").Trim();
                if (choice == "4") break;

                string chars = choice == "1" ? "abcdefghijklmnopqrstuvwxyz" :
                               choice == "2" ? "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789" :
                               choice == "3" ? "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*" : "";
                int length = choice == "1" ? 6 : choice == "2" ? 10 : choice == "3" ? 14 : 0;
                if (length == 0) { Console.WriteLine("Invalid choice."); continue; }

                var r = new Random();
                char[] pass = new char[length];
                for (int i = 0; i < length; i++) pass[i] = chars[r.Next(chars.Length)];
                Console.WriteLine($"Generated password: {new string(pass)}");
            }
            Console.WriteLine("Generator closed.");
        }
    }
}
