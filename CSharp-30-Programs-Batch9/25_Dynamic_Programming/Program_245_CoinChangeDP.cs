// ============================================
// Program #245 — CoinChangeDP
// Category  : 25_Dynamic_Programming
// Difficulty: Intermediate
// Description: Find minimum coins needed to make a target sum using DP.
// ============================================

using System;

namespace CSharp30Programs.DynamicProgramming
{
    class Program_245_CoinChangeDP
    {
        static void Main(string[] args)
        {
            int[] coins = { 1, 3, 4 };
            int amount = 6;
            int[] dp = new int[amount + 1];
            int INF = amount + 1;

            for (int i = 1; i <= amount; i++) dp[i] = INF;

            for (int i = 1; i <= amount; i++)
            {
                for (int c = 0; c < coins.Length; c++)
                {
                    if (coins[c] <= i)
                        dp[i] = Math.Min(dp[i], dp[i - coins[c]] + 1);
                }
            }

            string result = dp[amount] > amount ? "Not possible" : dp[amount].ToString();
            Console.WriteLine($"Minimum coins for {amount} = {result}");
        }
    }
}
