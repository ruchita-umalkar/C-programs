// ============================================
// Program #247 — EditDistance
// Category  : 25_Dynamic_Programming
// Difficulty: Intermediate
// Description: Compute Levenshtein edit distance between two strings using DP.
// ============================================

using System;

namespace CSharp30Programs.DynamicProgramming
{
    class Program_247_EditDistance
    {
        static void Main(string[] args)
        {
            string s1 = "kitten";
            string s2 = "sitting";
            int[,] dp = new int[s1.Length + 1, s2.Length + 1];

            for (int i = 0; i <= s1.Length; i++) dp[i, 0] = i;
            for (int j = 0; j <= s2.Length; j++) dp[0, j] = j;

            for (int i = 1; i <= s1.Length; i++)
            {
                for (int j = 1; j <= s2.Length; j++)
                {
                    int cost = s1[i - 1] == s2[j - 1] ? 0 : 1;
                    dp[i, j] = Math.Min(
                        Math.Min(dp[i - 1, j] + 1, dp[i, j - 1] + 1),
                        dp[i - 1, j - 1] + cost
                    );
                }
            }

            Console.WriteLine($"Edit distance between '{s1}' and '{s2}' = {dp[s1.Length, s2.Length]}");
        }
    }
}
