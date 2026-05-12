// ============================================
// Program #157 — LambdaClosure
// Category  : 16_Lambda_Expressions
// Difficulty: Intermediate
// Description: Demonstrates closure by capturing an outer variable
// ============================================

using System;

namespace CSharp30Programs.LambdaExpressions
{
    class Program_157_LambdaClosure
    {
        static void Main(string[] args)
        {
            int multiplier = 5;
            Func<int, int> multiply = n => n * multiplier;

            Console.WriteLine($"7 x {multiplier} = {multiply(7)}");
        }
    }
}
