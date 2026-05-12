// ============================================
// Program #249 — StaircaseClimb
// Category  : 25_Dynamic_Programming
// Difficulty: Intermediate
// Description: Count ways to climb stairs taking 1 or 2 steps at a time.
// ============================================

using System;

namespace CSharp30Programs.DynamicProgramming
{
    class Program_249_StaircaseClimb
    {
        static void Main(string[] args)
        {
            int n = 8;
            if (n <= 1)
            {
                Console.WriteLine($"Ways to climb {n} stairs = 1");
                return;
            }

            int[] dp = new int[n + 1];
            dp[0] = 1;
            dp[1] = 1;

            for (int i = 2; i <= n; i++)
                dp[i] = dp[i - 1] + dp[i - 2];

            Console.WriteLine($"Ways to climb {n} stairs = {dp[n]}");
        }
    }
}
