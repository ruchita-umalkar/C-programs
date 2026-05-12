// ============================================
// Program #71 — LINQWhereSelect
// Category  : 08_LINQ
// Difficulty: Basic
// Description: Filter and project values using LINQ Where and Select
// ============================================

using System;
using System.Linq;

namespace CSharp30Programs._08_LINQ
{
    class Program_71_LINQWhereSelect
    {
        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(1, 10);
            var squaresOfEven = numbers.Where(n => n % 2 == 0).Select(n => n * n);
            Console.WriteLine($"Squares of even numbers: {string.Join(", ", squaresOfEven)}");
        }
    }
}
