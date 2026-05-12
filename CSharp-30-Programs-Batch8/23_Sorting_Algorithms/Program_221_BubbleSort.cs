// ============================================
// Program #221 — BubbleSort
// Category  : 23_Sorting_Algorithms
// Difficulty: Intermediate
// Description: Bubble sort with step by step output
// ============================================

using System;

namespace CSharp30Programs.SortingAlgorithms
{
    class Program_221_BubbleSort
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 1, 4, 2, 8 };
            Console.WriteLine("Initial: " + string.Join(", ", arr));

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
                Console.WriteLine($"After pass {i + 1}: {string.Join(", ", arr)}");
            }

        }
    }
}
