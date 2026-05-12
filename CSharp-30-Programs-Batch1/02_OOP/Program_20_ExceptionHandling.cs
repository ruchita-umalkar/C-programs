// ============================================
// Program #20 — ExceptionHandling
// Category  : 02_OOP
// Difficulty: Intermediate
// Description: Throw and catch a custom InvalidAgeException
// ============================================

using System;

namespace CSharp30Programs.OOP
{
    class InvalidAgeException : Exception
    {
        public InvalidAgeException(string message) : base(message)
        {
        }
    }

    class Program_20_ExceptionHandling
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an age:");
            int age;
            if (!int.TryParse(Console.ReadLine(), out age))
            {
                age = 0;
            }

            try
            {
                if (age < 0)
                {
                    throw new InvalidAgeException("Age cannot be negative.");
                }

                Console.WriteLine($"Age accepted: {age}");
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine($"Custom error: {ex.Message}");
            }
        }
    }
}
