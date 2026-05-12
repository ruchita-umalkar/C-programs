// ============================================
// Program #70 — GroupByCollection
// Category  : 07_Collections
// Difficulty: Intermediate
// Description: Group collection values and print grouped counts
// ============================================

using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp30Programs._07_Collections
{
    class Program_70_GroupByCollection
    {
        static void Main(string[] args)
        {
            var words = new List<string> { "apple", "ant", "banana", "ball", "cat" };
            var groups = words.GroupBy(word => word[0]);
            foreach (var group in groups)
            {
                Console.WriteLine($"{group.Key}: {group.Count()} words");
            }
        }
    }
}
