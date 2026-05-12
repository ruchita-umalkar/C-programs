// ============================================
// Program #3 — ArithmeticOps
// Category  : 01_Basics
// Difficulty: Basic
// Description: Perform addition, subtraction, multiplication, and division
// ============================================

using System;

namespace CSharp30Programs.Basics
{
    class Program_3_ArithmeticOps
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            double first;
            if (!double.TryParse(Console.ReadLine(), out first))
            {
                first = 0;
            }

            Console.WriteLine("Enter the second number:");
            double second;
            if (!double.TryParse(Console.ReadLine(), out second))
            {
                second = 0;
            }

            Console.WriteLine($"Addition: {first + second}");
            Console.WriteLine($"Subtraction: {first - second}");
            Console.WriteLine($"Multiplication: {first * second}");
            if (second != 0)
            {
                Console.WriteLine($"Division: {first / second}");
            }
            else
            {
                Console.WriteLine("Division: undefined (division by zero)");
            }
        }
    }
}
