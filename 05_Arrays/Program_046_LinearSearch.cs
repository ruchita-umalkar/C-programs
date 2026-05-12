// ============================================
// Program #046 — LinearSearch
// Category  : 05_Arrays
// Difficulty: Basic
// Description: Search element in array using linear search
// ============================================

using System;

namespace CSharp30Programs.Arrays
{
    class Program_046_LinearSearch
    {
        static void Main(string[] args)
        {
            int[] numbers = { 8, 3, 11, 7, 15, 2 };
            int target = 7;
            int index = -1;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == target)
                {
                    index = i;
                    break;
                }
            }

            Console.WriteLine(index >= 0
                ? $"Element {target} found at index {index}."
                : $"Element {target} not found.");
        }
    }
}
