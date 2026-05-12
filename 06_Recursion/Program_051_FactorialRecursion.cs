// ============================================
// Program #051 — FactorialRecursion
// Category  : 06_Recursion
// Difficulty: Basic
// Description: Factorial of a number using recursion
// ============================================

using System;

namespace CSharp30Programs.Recursion
{
    class Program_051_FactorialRecursion
    {
        static void Main(string[] args)
        {
            int number = 5;
            Console.WriteLine($"Factorial of {number} is {Factorial(number)}");
        }

        static long Factorial(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("Factorial is not defined for negative numbers.");
            }

            if (n <= 1)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }
    }
}
