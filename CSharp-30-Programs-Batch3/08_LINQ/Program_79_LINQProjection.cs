// ============================================
// Program #79 — LINQProjection
// Category  : 08_LINQ
// Difficulty: Intermediate
// Description: Project objects into anonymous summaries
// ============================================

using System;
using System.Linq;

namespace CSharp30Programs._08_LINQ
{
    class Program_79_LINQProjection
    {
        static void Main(string[] args)
        {
            var products = new[]
            {
                new { Name = "Pen", Price = 12.5 },
                new { Name = "Book", Price = 90.0 }
            };
            var projections = products.Select(p => new { p.Name, PriceWithTax = p.Price * 1.18 });
            foreach (var item in projections)
            {
                Console.WriteLine($"{item.Name}: {item.PriceWithTax:F2}");
            }
        }
    }
}
