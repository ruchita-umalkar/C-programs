// ============================================
// Program #242 — KnapsackDP
// Category  : 25_Dynamic_Programming
// Difficulty: Intermediate
// Description: Solve 0/1 Knapsack using DP table and print the maximum value.
// ============================================

using System;

namespace CSharp30Programs.DynamicProgramming
{
    class Program_242_KnapsackDP
    {
        static void Main(string[] args)
        {
            int[] wt = { 1, 3, 4, 5 };
            int[] val = { 1, 4, 5, 7 };
            int capacity = 7;
            int n = wt.Length;

            int[,] dp = new int[n + 1, capacity + 1];

            for (int i = 1; i <= n; i++)
            {
                for (int w = 1; w <= capacity; w++)
                {
                    if (wt[i - 1] <= w)
                    {
                        int include = val[i - 1] + dp[i - 1, w - wt[i - 1]];
                        int exclude = dp[i - 1, w];
                        dp[i, w] = Math.Max(include, exclude);
                    }
                    else
                    {
                        dp[i, w] = dp[i - 1, w];
                    }
                }
            }

            Console.WriteLine($"Maximum value in knapsack = {dp[n, capacity]}");
        }
    }
}
