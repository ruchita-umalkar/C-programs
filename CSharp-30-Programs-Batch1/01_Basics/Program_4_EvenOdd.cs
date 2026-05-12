// ============================================
// Program #4 — EvenOdd
// Category  : 01_Basics
// Difficulty: Basic
// Description: Determine whether a number is even or odd
// ============================================

using System;

namespace CSharp30Programs.Basics
{
    class Program_4_EvenOdd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int number;
            if (!int.TryParse(Console.ReadLine(), out number))
            {
                number = 0;
            }

            string result = number % 2 == 0 ? "even" : "odd";
            Console.WriteLine($"The number {number} is {result}.");
        }
    }
}
