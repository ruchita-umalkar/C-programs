// ============================================
// Program #155 — LambdaListSorting
// Category  : 16_Lambda_Expressions
// Difficulty: Intermediate
// Description: Sorts a list of strings by length using lambda expression
// ============================================

using System;
using System.Collections.Generic;

namespace CSharp30Programs.LambdaExpressions
{
    class Program_155_LambdaListSorting
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string> { "Ravi", "An", "Kiran", "Monica" };
            names.Sort((a, b) => a.Length.CompareTo(b.Length));

            Console.WriteLine("Sorted by length: " + string.Join(", ", names));
        }
    }
}
