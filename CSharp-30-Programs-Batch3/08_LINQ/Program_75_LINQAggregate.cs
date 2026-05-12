// ============================================
// Program #75 — LINQAggregate
// Category  : 08_LINQ
// Difficulty: Intermediate
// Description: Compute summary values using LINQ Aggregate
// ============================================

using System;
using System.Linq;

namespace CSharp30Programs._08_LINQ
{
    class Program_75_LINQAggregate
    {
        static void Main(string[] args)
        {
            var values = new[] { 2, 4, 6, 8 };
            int product = values.Aggregate(1, (acc, value) => acc * value);
            Console.WriteLine($"Product: {product}");
        }
    }
}
