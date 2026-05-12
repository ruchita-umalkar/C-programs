// ============================================
// Program #238 — SentinelSearch
// Category  : 24_Searching_Algorithms
// Difficulty: Intermediate
// Description: Sentinel linear search reducing comparisons
// ============================================

using System;

namespace CSharp30Programs.SearchingAlgorithms
{
    class Program_238_SentinelSearch
    {
        static void Main(string[] args)
        {
            int[] arr = { 12, 34, 54, 2, 3 };
            int target = 2;
            int n = arr.Length;
            int last = arr[n - 1];
            arr[n - 1] = target;

            int i = 0;
            while (arr[i] != target) i++;

            arr[n - 1] = last;

            if (i < n - 1 || arr[n - 1] == target)
                Console.WriteLine($"Found {target} at index {i}");
            else
                Console.WriteLine("Not found");

        }
    }
}
