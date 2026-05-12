// ============================================
// Program #68 — CollectionIteration
// Category  : 07_Collections
// Difficulty: Basic
// Description: Iterate through collection elements with index values
// ============================================

using System;
using System.Collections.Generic;

namespace CSharp30Programs._07_Collections
{
    class Program_68_CollectionIteration
    {
        static void Main(string[] args)
        {
            var colors = new List<string> { "Red", "Green", "Blue" };
            for (int i = 0; i < colors.Count; i++)
            {
                Console.WriteLine($"Index {i}: {colors[i]}");
            }
        }
    }
}
