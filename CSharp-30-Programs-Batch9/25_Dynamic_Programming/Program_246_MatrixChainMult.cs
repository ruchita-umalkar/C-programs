// ============================================
// Program #246 — MatrixChainMult
// Category  : 25_Dynamic_Programming
// Difficulty: Intermediate
// Description: Compute minimum scalar multiplications for matrix chain multiplication.
// ============================================

using System;

namespace CSharp30Programs.DynamicProgramming
{
    class Program_246_MatrixChainMult
    {
        static void Main(string[] args)
        {
            int[] p = { 40, 20, 30, 10, 30 };
            int n = p.Length - 1;
            int[,] dp = new int[n, n];

            for (int len = 2; len <= n; len++)
            {
                for (int i = 0; i <= n - len; i++)
                {
                    int j = i + len - 1;
                    dp[i, j] = int.MaxValue;

                    for (int k = i; k < j; k++)
                    {
                        int cost = dp[i, k] + dp[k + 1, j] + p[i] * p[k + 1] * p[j + 1];
                        if (cost < dp[i, j]) dp[i, j] = cost;
                    }
                }
            }

            Console.WriteLine($"Minimum multiplication cost = {dp[0, n - 1]}");
        }
    }
}
