// ============================================
// Program #052 — FibonacciRecursion
// Category  : 06_Recursion
// Difficulty: Basic
// Description: Fibonacci series using recursion
// ============================================

using System;

namespace CSharp30Programs.Recursion
{
    class Program_052_FibonacciRecursion
    {
        static void Main(string[] args)
        {
            int terms = 8;
            int[] memo = new int[terms];
            for (int i = 0; i < memo.Length; i++)
            {
                memo[i] = -1;
            }

            Console.WriteLine($"First {terms} Fibonacci terms:");

            for (int i = 0; i < terms; i++)
            {
                Console.Write(Fibonacci(i, memo) + " ");
            }

            Console.WriteLine();
        }

        static int Fibonacci(int n, int[] memo)
        {
            if (n <= 1)
            {
                return n;
            }

            if (memo[n] != -1)
            {
                return memo[n];
            }

            memo[n] = Fibonacci(n - 1, memo) + Fibonacci(n - 2, memo);
            return memo[n];
        }
    }
}
