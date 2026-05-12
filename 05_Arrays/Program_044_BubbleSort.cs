// ============================================
// Program #044 — BubbleSort
// Category  : 05_Arrays
// Difficulty: Basic
// Description: Sort array using bubble sort algorithm
// ============================================

using System;

namespace CSharp30Programs.Arrays
{
    class Program_044_BubbleSort
    {
        static void Main(string[] args)
        {
            int[] numbers = { 64, 34, 25, 12, 22, 11, 90 };

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = 0; j < numbers.Length - i - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("Sorted array: " + string.Join(", ", numbers));
        }
    }
}
