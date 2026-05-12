// ============================================
// Program #66 — SortedListDemo
// Category  : 07_Collections
// Difficulty: Intermediate
// Description: Store key-value pairs in sorted key order
// ============================================

using System;
using System.Collections.Generic;

namespace CSharp30Programs._07_Collections
{
    class Program_66_SortedListDemo
    {
        static void Main(string[] args)
        {
            var products = new SortedList<int, string>
            {
                [103] = "Keyboard",
                [101] = "Mouse",
                [102] = "Monitor"
            };
            foreach (var item in products)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
