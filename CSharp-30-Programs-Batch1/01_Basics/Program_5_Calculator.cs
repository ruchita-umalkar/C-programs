// ============================================
// Program #5 — Calculator
// Category  : 01_Basics
// Difficulty: Basic
// Description: Simple calculator using switch with divide-by-zero handling
// ============================================

using System;

namespace CSharp30Programs.Basics
{
    class Program_5_Calculator
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

            Console.WriteLine("Choose operation (+, -, *, /):");
            string operation = Console.ReadLine() ?? string.Empty;
            const double tolerance = 1e-9;

            switch (operation)
            {
                case "+":
                    Console.WriteLine($"Result: {first + second}");
                    break;
                case "-":
                    Console.WriteLine($"Result: {first - second}");
                    break;
                case "*":
                    Console.WriteLine($"Result: {first * second}");
                    break;
                case "/":
                    if (Math.Abs(second) < tolerance)
                    {
                        Console.WriteLine("Error: Division by zero.");
                    }
                    else
                    {
                        Console.WriteLine($"Result: {first / second}");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operation selected.");
                    break;
            }
        }
    }
}
