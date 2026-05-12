// ============================================
// Program #222 — SelectionSort
// Category  : 23_Sorting_Algorithms
// Difficulty: Intermediate
// Description: Selection sort with min element tracking
// ============================================

using System;

namespace CSharp30Programs.SortingAlgorithms
{
    class Program_222_SelectionSort
    {
        static void Main(string[] args)
        {
            int[] arr = { 64, 25, 12, 22, 11 };
            Console.WriteLine("Initial: " + string.Join(", ", arr));

            for (int i = 0; i < arr.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minIndex]) minIndex = j;
                }
                Console.WriteLine($"Pass {i + 1}, min element {arr[minIndex]} at index {minIndex}");
                int temp = arr[i]; arr[i] = arr[minIndex]; arr[minIndex] = temp;
                Console.WriteLine("Array: " + string.Join(", ", arr));
            }

        }
    }
}
