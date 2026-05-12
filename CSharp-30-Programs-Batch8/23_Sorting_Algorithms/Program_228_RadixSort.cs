// ============================================
// Program #228 — RadixSort
// Category  : 23_Sorting_Algorithms
// Difficulty: Intermediate
// Description: Radix sort using LSD approach digit by digit
// ============================================

using System;

namespace CSharp30Programs.SortingAlgorithms
{
    class Program_228_RadixSort
    {
        static void Main(string[] args)
        {
            int[] arr = { 170, 45, 75, 90, 802, 24, 2, 66 };
            Console.WriteLine("Initial: " + string.Join(", ", arr));

            int max = arr[0];
            foreach (int x in arr) if (x > max) max = x;

            void CountSortByDigit(int exp)
            {
                int n = arr.Length;
                int[] output = new int[n];
                int[] count = new int[10];

                for (int i = 0; i < n; i++) count[(arr[i] / exp) % 10]++;
                for (int i = 1; i < 10; i++) count[i] += count[i - 1];

                for (int i = n - 1; i >= 0; i--)
                {
                    int digit = (arr[i] / exp) % 10;
                    output[count[digit] - 1] = arr[i];
                    count[digit]--;
                }

                for (int i = 0; i < n; i++) arr[i] = output[i];
            }

            for (int exp = 1; max / exp > 0; exp *= 10)
            {
                CountSortByDigit(exp);
                Console.WriteLine($"After exp {exp}: {string.Join(", ", arr)}");
            }

        }
    }
}
