// ============================================
// Program #244 — LongestIncSubseq
// Category  : 25_Dynamic_Programming
// Difficulty: Intermediate
// Description: Compute Longest Increasing Subsequence length using dynamic programming.
// ============================================

using System;

namespace CSharp30Programs.DynamicProgramming
{
    class Program_244_LongestIncSubseq
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 22, 9, 33, 21, 50, 41, 60 };
            int n = arr.Length;
            int[] lis = new int[n];

            for (int i = 0; i < n; i++) lis[i] = 1;

            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[i] > arr[j] && lis[i] < lis[j] + 1)
                        lis[i] = lis[j] + 1;
                }
            }

            int maxLis = 0;
            for (int i = 0; i < n; i++) maxLis = Math.Max(maxLis, lis[i]);

            Console.WriteLine($"LIS length = {maxLis}");
        }
    }
}
