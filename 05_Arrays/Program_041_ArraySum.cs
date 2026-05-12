// ============================================
// Program #041 — ArraySum
// Category  : 05_Arrays
// Difficulty: Basic
// Description: Sum and average of array elements
// ============================================

using System;

namespace CSharp30Programs.Arrays
{
    class Program_041_ArraySum
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 20, 30, 40, 50 };
            int sum = 0;

            foreach (int number in numbers)
            {
                sum += number;
            }

            double average = (double)sum / numbers.Length;

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Average: {average:F2}");
        }
    }
}
