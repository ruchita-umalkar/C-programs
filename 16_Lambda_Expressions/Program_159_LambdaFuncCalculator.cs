// ============================================
// Program #159 — LambdaFuncCalculator
// Category  : 16_Lambda_Expressions
// Difficulty: Intermediate
// Description: Performs arithmetic operations using Func lambdas
// ============================================

using System;

namespace CSharp30Programs.LambdaExpressions
{
    class Program_159_LambdaFuncCalculator
    {
        static void Main(string[] args)
        {
            Func<double, double, double> divide = (a, b) => b == 0 ? double.NaN : a / b;
            Func<double, double, double> multiply = (a, b) => a * b;

            Console.WriteLine($"20 / 4 = {divide(20, 4)}");
            Console.WriteLine($"6 * 7 = {multiply(6, 7)}");
        }
    }
}
