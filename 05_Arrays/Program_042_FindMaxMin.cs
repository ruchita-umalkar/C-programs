// ============================================
// Program #042 — FindMaxMin
// Category  : 05_Arrays
// Difficulty: Basic
// Description: Find max and min in an array without built-ins
// ============================================

using System;

namespace CSharp30Programs.Arrays
{
    class Program_042_FindMaxMin
    {
        static void Main(string[] args)
        {
            int[] numbers = { 23, 5, 89, 12, 44, 2, 67 };
            int min = numbers[0];
            int max = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }

                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }

            Console.WriteLine($"Min: {min}");
            Console.WriteLine($"Max: {max}");
        }
    }
}
