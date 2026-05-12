// ============================================
// Program #77 — LINQAnyAll
// Category  : 08_LINQ
// Difficulty: Basic
// Description: Check conditions across sequences with Any and All
// ============================================

using System;
using System.Linq;

namespace CSharp30Programs._08_LINQ
{
    class Program_77_LINQAnyAll
    {
        static void Main(string[] args)
        {
            var marks = new[] { 75, 82, 91, 68 };
            bool anyDistinction = marks.Any(m => m >= 90);
            bool allPassed = marks.All(m => m >= 35);
            Console.WriteLine($"Any distinction: {anyDistinction}");
            Console.WriteLine($"All passed: {allPassed}");
        }
    }
}
