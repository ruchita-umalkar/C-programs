// ============================================
// Program #101 — MathBasics
// Category  : 11_Math_Operations
// Difficulty: Basic
// Description: Demonstrate basic Math class operations
// ============================================

using System;

namespace CSharp30Programs.MathOperations
{
    class Program_101_MathBasics
    {
        static void Main(string[] args)
        {
            double number = 25.75;
            Console.WriteLine($"Number: {number}");
            Console.WriteLine($"Sqrt(25): {Math.Sqrt(25)}");
            Console.WriteLine($"Pow(2, 5): {Math.Pow(2, 5)}");
            Console.WriteLine($"Abs(-42): {Math.Abs(-42)}");
            Console.WriteLine($"Round(25.75): {Math.Round(number)}");
            Console.WriteLine($"Floor(25.75): {Math.Floor(number)}");
            Console.WriteLine($"Ceiling(25.75): {Math.Ceiling(number)}");
        }
    }
}
