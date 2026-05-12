// ============================================
// Program #229 — ShellSort
// Category  : 23_Sorting_Algorithms
// Difficulty: Intermediate
// Description: Shell sort with gap sequence and comparisons
// ============================================

using System;

namespace CSharp30Programs.SortingAlgorithms
{
    class Program_229_ShellSort
    {
        static void Main(string[] args)
        {
            int[] arr = { 12, 34, 54, 2, 3 };
            Console.WriteLine("Initial: " + string.Join(", ", arr));

            for (int gap = arr.Length / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < arr.Length; i++)
                {
                    int temp = arr[i];
                    int j;
                    for (j = i; j >= gap && arr[j - gap] > temp; j -= gap)
                        arr[j] = arr[j - gap];
                    arr[j] = temp;
                }
                Console.WriteLine($"After gap {gap}: {string.Join(", ", arr)}");
            }

        }
    }
}
