// ============================================
// Program #76 — LINQFirstSingle
// Category  : 08_LINQ
// Difficulty: Basic
// Description: Find elements using FirstOrDefault and SingleOrDefault
// ============================================

using System;
using System.Linq;

namespace CSharp30Programs._08_LINQ
{
    class Program_76_LINQFirstSingle
    {
        static void Main(string[] args)
        {
            var ids = new[] { 101, 102, 103 };
            int first = ids.FirstOrDefault(i => i > 101);
            int single = ids.SingleOrDefault(i => i == 102);
            Console.WriteLine($"First > 101: {first}");
            Console.WriteLine($"Single == 102: {single}");
        }
    }
}
