// ============================================
// Program #154 — LambdaAsPredicate
// Category  : 16_Lambda_Expressions
// Difficulty: Intermediate
// Description: Filters values using Predicate with lambda
// ============================================

using System;
using System.Collections.Generic;

namespace CSharp30Programs.LambdaExpressions
{
    class Program_154_LambdaAsPredicate
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 3, 10, 17, 22, 31 };
            Predicate<int> isGreaterThan15 = n => n > 15;

            List<int> filtered = numbers.FindAll(isGreaterThan15);
            Console.WriteLine("Numbers greater than 15: " + string.Join(", ", filtered));
        }
    }
}
