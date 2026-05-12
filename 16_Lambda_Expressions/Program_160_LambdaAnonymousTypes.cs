// ============================================
// Program #160 — LambdaAnonymousTypes
// Category  : 16_Lambda_Expressions
// Difficulty: Intermediate
// Description: Projects data into anonymous types using Select lambda
// ============================================

using System;
using System.Linq;

namespace CSharp30Programs.LambdaExpressions
{
    class Program_160_LambdaAnonymousTypes
    {
        static void Main(string[] args)
        {
            string[] fruits = { "apple", "banana", "kiwi" };
            var result = fruits.Select(f => new { Name = f, Length = f.Length });

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Name} -> {item.Length}");
            }
        }
    }
}
