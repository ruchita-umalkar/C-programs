// ============================================
// Program #227 — CountingSort
// Category  : 23_Sorting_Algorithms
// Difficulty: Intermediate
// Description: Counting sort for non-negative integer arrays
// ============================================

using System;

namespace CSharp30Programs.SortingAlgorithms
{
    class Program_227_CountingSort
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 2, 2, 8, 3, 3, 1 };
            Console.WriteLine("Initial: " + string.Join(", ", arr));

            int max = arr[0];
            foreach (int x in arr) if (x > max) max = x;

            int[] count = new int[max + 1];
            foreach (int x in arr) count[x]++;

            int index = 0;
            for (int i = 0; i < count.Length; i++)
            {
                while (count[i]-- > 0)
                    arr[index++] = i;
            }

            Console.WriteLine("Sorted: " + string.Join(", ", arr));

        }
    }
}
