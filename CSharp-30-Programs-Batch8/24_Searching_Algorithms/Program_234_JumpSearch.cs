// ============================================
// Program #234 — JumpSearch
// Category  : 24_Searching_Algorithms
// Difficulty: Intermediate
// Description: Jump search with block size sqrt(n) demo
// ============================================

using System;

namespace CSharp30Programs.SearchingAlgorithms
{
    class Program_234_JumpSearch
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21 };
            int target = 15;
            int n = arr.Length;
            int step = (int)System.Math.Sqrt(n);
            int prev = 0;

            while (prev < n && arr[System.Math.Min(step, n) - 1] < target)
            {
                Console.WriteLine($"Jump to block ending at index {System.Math.Min(step, n) - 1}");
                prev = step;
                step += (int)System.Math.Sqrt(n);
                if (prev >= n)
                {
                    Console.WriteLine("Not found");
                    return;
                }
            }

            while (prev < System.Math.Min(step, n) && arr[prev] < target)
            {
                Console.WriteLine($"Linear scan index {prev}");
                prev++;
            }

            Console.WriteLine(prev < n && arr[prev] == target ? $"Found at index {prev}" : "Not found");

        }
    }
}
