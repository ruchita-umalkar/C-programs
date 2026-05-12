// ============================================
// Program #239 — MetaBinarySearch
// Category  : 24_Searching_Algorithms
// Difficulty: Intermediate
// Description: Meta binary search using bit manipulation
// ============================================

using System;

namespace CSharp30Programs.SearchingAlgorithms
{
    class Program_239_MetaBinarySearch
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 3, 5, 7, 9, 11, 13, 15, 17 };
            int target = 13;
            int n = arr.Length;
            int lg = (int)System.Math.Log(n - 1, 2);
            int pos = 0;

            for (int i = lg; i >= 0; i--)
            {
                int newPos = pos | (1 << i);
                if (newPos < n && arr[newPos] <= target)
                {
                    Console.WriteLine($"Set bit {i}: pos {pos} -> {newPos}");
                    pos = newPos;
                }
            }

            Console.WriteLine(arr[pos] == target ? $"Found {target} at index {pos}" : "Not found");

        }
    }
}
