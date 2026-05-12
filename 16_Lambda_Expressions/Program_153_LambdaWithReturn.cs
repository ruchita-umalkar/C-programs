// ============================================
// Program #153 — LambdaWithReturn
// Category  : 16_Lambda_Expressions
// Difficulty: Intermediate
// Description: Uses a statement lambda with explicit return logic
// ============================================

using System;

namespace CSharp30Programs.LambdaExpressions
{
    class Program_153_LambdaWithReturn
    {
        static void Main(string[] args)
        {
            Func<int, string> parity = n =>
            {
                return n % 2 == 0 ? "Even" : "Odd";
            };

            Console.WriteLine($"15 is {parity(15)}");
        }
    }
}
