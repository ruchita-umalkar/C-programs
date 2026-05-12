// ============================================
// Program #223 — InsertionSort
// Category  : 23_Sorting_Algorithms
// Difficulty: Intermediate
// Description: Insertion sort shifting elements right
// ============================================

using System;

namespace CSharp30Programs.SortingAlgorithms
{
    class Program_223_InsertionSort
    {
        static void Main(string[] args)
        {
            int[] arr = { 9, 5, 1, 4, 3 };
            Console.WriteLine("Initial: " + string.Join(", ", arr));

            for (int i = 1; i < arr.Length; i++)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
                Console.WriteLine($"After inserting {key}: {string.Join(", ", arr)}");
            }

        }
    }
}
