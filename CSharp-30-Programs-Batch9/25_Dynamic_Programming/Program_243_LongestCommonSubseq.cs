// ============================================
// Program #243 — LongestCommonSubseq
// Category  : 25_Dynamic_Programming
// Difficulty: Intermediate
// Description: Find the length of Longest Common Subsequence between two strings.
// ============================================

using System;

namespace CSharp30Programs.DynamicProgramming
{
    class Program_243_LongestCommonSubseq
    {
        static void Main(string[] args)
        {
            string a = "AGGTAB";
            string b = "GXTXAYB";
            int[,] dp = new int[a.Length + 1, b.Length + 1];

            for (int i = 1; i <= a.Length; i++)
            {
                for (int j = 1; j <= b.Length; j++)
                {
                    if (a[i - 1] == b[j - 1])
                        dp[i, j] = dp[i - 1, j - 1] + 1;
                    else
                        dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                }
            }

            Console.WriteLine($"LCS length of '{a}' and '{b}' = {dp[a.Length, b.Length]}");
        }
    }
}
