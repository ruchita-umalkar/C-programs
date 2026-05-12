// ============================================
// Program #241 — FibonacciDP
// Category  : 25_Dynamic_Programming
// Difficulty: Intermediate
// Description: Compare Fibonacci using naive recursion and memoization.
// ============================================

using System;

namespace CSharp30Programs.DynamicProgramming
{
    class Program_241_FibonacciDP
    {
        static int NaiveFib(int n)
        {
            if (n <= 1) return n;
            return NaiveFib(n - 1) + NaiveFib(n - 2);
        }

        static int MemoFib(int n, int[] memo)
        {
            if (n <= 1) return n;
            if (memo[n] != -1) return memo[n];
            memo[n] = MemoFib(n - 1, memo) + MemoFib(n - 2, memo);
            return memo[n];
        }

        static void Main(string[] args)
        {
            int n = 10;
            int[] memo = new int[n + 1];
            for (int i = 0; i <= n; i++) memo[i] = -1;

            Console.WriteLine($"Naive Fibonacci({n}) = {NaiveFib(n)}");
            Console.WriteLine($"Memoized Fibonacci({n}) = {MemoFib(n, memo)}");
        }
    }
}
