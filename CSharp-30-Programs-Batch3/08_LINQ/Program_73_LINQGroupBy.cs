// ============================================
// Program #73 — LINQGroupBy
// Category  : 08_LINQ
// Difficulty: Intermediate
// Description: Group numbers by odd and even categories
// ============================================

using System;
using System.Linq;

namespace CSharp30Programs._08_LINQ
{
    class Program_73_LINQGroupBy
    {
        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(1, 8);
            var grouped = numbers.GroupBy(n => n % 2 == 0 ? "Even" : "Odd");
            foreach (var group in grouped)
            {
                Console.WriteLine($"{group.Key}: {string.Join(", ", group)}");
            }
        }
    }
}
