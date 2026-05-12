// ============================================
// Program #158 — LambdaActionDemo
// Category  : 16_Lambda_Expressions
// Difficulty: Intermediate
// Description: Uses Action delegate with a lambda for console output
// ============================================

using System;

namespace CSharp30Programs.LambdaExpressions
{
    class Program_158_LambdaActionDemo
    {
        static void Main(string[] args)
        {
            Action<string> printMessage = message => Console.WriteLine($"Message: {message}");
            printMessage("Lambda with Action delegate");
        }
    }
}
