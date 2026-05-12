// ============================================
// Program #30 — MiniCalculator
// Category  : 03_Intermediate
// Difficulty: Intermediate
// Description: Run a mini calculator loop with basic operations
// ============================================

using System;

namespace CSharp30Programs.Intermediate
{
    class Program_30_MiniCalculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mini Calculator (type Q to quit)");
            const double tolerance = 1e-9;

            while (true)
            {
                Console.WriteLine("Enter operation (+, -, *, /) or Q to quit:");
                string operation = Console.ReadLine() ?? string.Empty;

                if (operation.Equals("Q", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Calculator exiting.");
                    break;
                }

                Console.WriteLine("Enter the first number:");
                if (!double.TryParse(Console.ReadLine(), out double first))
                {
                    Console.WriteLine("Invalid number.");
                    continue;
                }

                Console.WriteLine("Enter the second number:");
                if (!double.TryParse(Console.ReadLine(), out double second))
                {
                    Console.WriteLine("Invalid number.");
                    continue;
                }

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
                        Console.WriteLine("Unknown operation.");
                        break;
                }
            }
        }
    }
}
