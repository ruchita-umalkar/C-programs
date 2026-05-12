// ============================================
// Program #152 — LambdaWithParameters
// Category  : 16_Lambda_Expressions
// Difficulty: Intermediate
// Description: Uses a lambda expression with multiple parameters
// ============================================

using System;

namespace CSharp30Programs.LambdaExpressions
{
    class Program_152_LambdaWithParameters
    {
        static void Main(string[] args)
        {
            Func<int, int, int> add = (a, b) => a + b;
            Console.WriteLine($"Sum of 12 and 8 is {add(12, 8)}");
        }
    }
}
