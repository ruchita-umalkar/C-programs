// ============================================
// Program #6 — FibonacciLoop
// Category  : 01_Basics
// Difficulty: Basic
// Description: Print the first 15 Fibonacci numbers with index
// ============================================

using System;

namespace CSharp30Programs.Basics
{
    class Program_6_FibonacciLoop
    {
        static void Main(string[] args)
        {
            int count = 15;
            long first = 0;
            long second = 1;

            for (int i = 1; i <= count; i++)
            {
                Console.WriteLine($"Index {i}: {first}");
                long next = first + second;
                first = second;
                second = next;
            }
        }
    }
}
