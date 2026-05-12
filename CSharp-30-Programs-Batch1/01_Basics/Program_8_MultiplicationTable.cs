// ============================================
// Program #8 — MultiplicationTable
// Category  : 01_Basics
// Difficulty: Basic
// Description: Print a multiplication table from 1 to 12
// ============================================

using System;

namespace CSharp30Programs.Basics
{
    class Program_8_MultiplicationTable
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int number;
            if (!int.TryParse(Console.ReadLine(), out number))
            {
                number = 0;
            }

            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{number} x {i} = {number * i}");
            }
        }
    }
}
