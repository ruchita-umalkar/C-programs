// ============================================
// Program #7 — PrimeCheck
// Category  : 01_Basics
// Difficulty: Basic
// Description: Check if a number is prime and show divisors tested
// ============================================

using System;

namespace CSharp30Programs.Basics
{
    class Program_7_PrimeCheck
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to check for prime:");
            int number;
            if (!int.TryParse(Console.ReadLine(), out number))
            {
                number = 0;
            }

            if (number <= 1)
            {
                Console.WriteLine($"{number} is not a prime number.");
                return;
            }

            bool isPrime = true;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                Console.WriteLine($"Checking divisor {i}");
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            Console.WriteLine(isPrime
                ? $"{number} is a prime number."
                : $"{number} is not a prime number.");
        }
    }
}
