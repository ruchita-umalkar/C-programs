// ============================================
// Program #63 — HashSetDemo
// Category  : 07_Collections
// Difficulty: Basic
// Description: Show unique value handling using HashSet
// ============================================

using System;
using System.Collections.Generic;

namespace CSharp30Programs._07_Collections
{
    class Program_63_HashSetDemo
    {
        static void Main(string[] args)
        {
            var values = new HashSet<int> { 1, 2, 2, 3, 4, 4 };
            values.Add(5);
            values.Remove(1);
            Console.WriteLine($"Unique values: {string.Join(", ", values)}");
            Console.WriteLine($"Contains 3: {values.Contains(3)}");
        }
    }
}
