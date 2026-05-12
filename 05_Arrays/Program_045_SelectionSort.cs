// ============================================
// Program #045 — SelectionSort
// Category  : 05_Arrays
// Difficulty: Basic
// Description: Sort array using selection sort algorithm
// ============================================

using System;

namespace CSharp30Programs.Arrays
{
    class Program_045_SelectionSort
    {
        static void Main(string[] args)
        {
            int[] numbers = { 29, 10, 14, 37, 13 };

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] < numbers[minIndex])
                    {
                        minIndex = j;
                    }
                }

                int temp = numbers[i];
                numbers[i] = numbers[minIndex];
                numbers[minIndex] = temp;
            }

            Console.WriteLine("Sorted array: " + string.Join(", ", numbers));
        }
    }
}
