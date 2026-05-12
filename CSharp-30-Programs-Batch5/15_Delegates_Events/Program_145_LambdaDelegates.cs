// ============================================
// Program #145 — LambdaDelegates
// Category  : 15_Delegates_Events
// Difficulty: Basic
// Description: Use lambda expressions with delegates
// ============================================

using System;

namespace CSharp30Programs.DelegatesEvents
{
    class Program_145_LambdaDelegates
    {
        static void Main(string[] args)
        {
            Func<int, int> square = n => n * n;
            Console.WriteLine($"Square of 9: {square(9)}");
        }


    }
}
