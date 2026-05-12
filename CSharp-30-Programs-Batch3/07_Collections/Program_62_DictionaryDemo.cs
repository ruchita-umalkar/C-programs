// ============================================
// Program #62 — DictionaryDemo
// Category  : 07_Collections
// Difficulty: Basic
// Description: Demonstrate adding, updating, and reading values from a Dictionary
// ============================================

using System;
using System.Collections.Generic;

namespace CSharp30Programs._07_Collections
{
    class Program_62_DictionaryDemo
    {
        static void Main(string[] args)
        {
            var scores = new Dictionary<string, int>
            {
                ["Alice"] = 90,
                ["Bob"] = 84
            };
            scores["Charlie"] = 95;
            scores["Bob"] = 88;
            foreach (var entry in scores)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }
            Console.WriteLine($"Contains Alice: {scores.ContainsKey("Alice")}");
        }
    }
}
