// ============================================
// Program #156 — LambdaWithLINQWhere
// Category  : 16_Lambda_Expressions
// Difficulty: Intermediate
// Description: Uses LINQ Where with lambda to filter even numbers
// ============================================

using System;
using System.Linq;

namespace CSharp30Programs.LambdaExpressions
{
    class Program_156_LambdaWithLINQWhere
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6 };
            var evens = numbers.Where(n => n % 2 == 0);

            Console.WriteLine("Even numbers: " + string.Join(", ", evens));
        }
    }
}
