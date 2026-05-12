// ============================================
// Program #248 — SubsetSumDP
// Category  : 25_Dynamic_Programming
// Difficulty: Intermediate
// Description: Check if a subset with target sum exists using dynamic programming.
// ============================================

using System;

namespace CSharp30Programs.DynamicProgramming
{
    class Program_248_SubsetSumDP
    {
        static void Main(string[] args)
        {
            int[] set = { 3, 34, 4, 12, 5, 2 };
            int target = 9;
            bool[,] dp = new bool[set.Length + 1, target + 1];

            for (int i = 0; i <= set.Length; i++) dp[i, 0] = true;

            for (int i = 1; i <= set.Length; i++)
            {
                for (int sum = 1; sum <= target; sum++)
                {
                    dp[i, sum] = dp[i - 1, sum];
                    if (set[i - 1] <= sum)
                        dp[i, sum] = dp[i, sum] || dp[i - 1, sum - set[i - 1]];
                }
            }

            Console.WriteLine($"Subset with sum {target} exists: {dp[set.Length, target]}");
        }
    }
}
