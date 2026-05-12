// ============================================
// Program #151 — LambdaBasics
// Category  : 16_Lambda_Expressions
// Difficulty: Intermediate
// Description: Demonstrates a basic lambda expression assigned to Func
// ============================================

using System;

namespace CSharp30Programs.LambdaExpressions
{
    class Program_151_LambdaBasics
    {
        static void Main(string[] args)
        {
            Func<int, int> square = x => x * x;
            Console.WriteLine($"Square of 6 is {square(6)}");
        }
    }
}
