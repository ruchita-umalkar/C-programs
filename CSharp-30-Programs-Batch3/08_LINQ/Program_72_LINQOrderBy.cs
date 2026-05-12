// ============================================
// Program #72 — LINQOrderBy
// Category  : 08_LINQ
// Difficulty: Basic
// Description: Sort strings by length and alphabetically using LINQ
// ============================================

using System;
using System.Linq;

namespace CSharp30Programs._08_LINQ
{
    class Program_72_LINQOrderBy
    {
        static void Main(string[] args)
        {
            var names = new[] { "Rohan", "Anu", "Kiran", "Dev" };
            var ordered = names.OrderBy(n => n.Length).ThenBy(n => n);
            Console.WriteLine($"Ordered names: {string.Join(", ", ordered)}");
        }
    }
}
