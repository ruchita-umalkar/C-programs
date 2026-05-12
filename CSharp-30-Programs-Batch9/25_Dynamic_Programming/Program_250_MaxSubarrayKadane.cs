// ============================================
// Program #250 — MaxSubarrayKadane
// Category  : 25_Dynamic_Programming
// Difficulty: Intermediate
// Description: Find maximum subarray sum using Kadane's algorithm.
// ============================================

using System;

namespace CSharp30Programs.DynamicProgramming
{
    class Program_250_MaxSubarrayKadane
    {
        static void Main(string[] args)
        {
            int[] arr = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            int maxEndingHere = arr[0];
            int maxSoFar = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                maxEndingHere = Math.Max(arr[i], maxEndingHere + arr[i]);
                maxSoFar = Math.Max(maxSoFar, maxEndingHere);
            }

            Console.WriteLine($"Maximum subarray sum = {maxSoFar}");
        }
    }
}
