// ============================================
// Program #61 — ListDemo
// Category  : 07_Collections
// Difficulty: Basic
// Description: Create a List, add/remove/sort/search elements
// ============================================

using System;
using System.Collections.Generic;

namespace CSharp30Programs._07_Collections
{
    class Program_61_ListDemo
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 5, 1, 9, 3 };
            numbers.Add(7);
            numbers.Remove(1);
            numbers.Sort();
            int index = numbers.IndexOf(9);
            Console.WriteLine($"Sorted List: {string.Join(", ", numbers)}");
            Console.WriteLine($"Index of 9: {index}");
        }
    }
}
