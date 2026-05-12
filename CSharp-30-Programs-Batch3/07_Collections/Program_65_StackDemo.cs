// ============================================
// Program #65 — StackDemo
// Category  : 07_Collections
// Difficulty: Basic
// Description: Demonstrate LIFO operations using Stack
// ============================================

using System;
using System.Collections.Generic;

namespace CSharp30Programs._07_Collections
{
    class Program_65_StackDemo
    {
        static void Main(string[] args)
        {
            var stack = new Stack<string>();
            stack.Push("Page 1");
            stack.Push("Page 2");
            stack.Push("Page 3");
            string current = stack.Pop();
            Console.WriteLine($"Popped: {current}");
            Console.WriteLine($"Top now: {stack.Peek()}");
            Console.WriteLine($"Stack items: {string.Join(", ", stack)}");
        }
    }
}
