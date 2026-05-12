// ============================================
// Program #23 — StackOperations
// Category  : 03_Intermediate
// Difficulty: Intermediate
// Description: Demonstrate stack push, pop, and peek operations
// ============================================

using System;
using System.Collections.Generic;

namespace CSharp30Programs.Intermediate
{
    class Program_23_StackOperations
    {
        static void Main(string[] args)
        {
            Stack<string> tasks = new Stack<string>();
            tasks.Push("Review code");
            tasks.Push("Write tests");
            tasks.Push("Fix bugs");

            Console.WriteLine("Stack contents: " + string.Join(", ", tasks));
            Console.WriteLine($"Peek: {tasks.Peek()}");

            string popped = tasks.Pop();
            Console.WriteLine($"Popped: {popped}");
            Console.WriteLine("After pop: " + string.Join(", ", tasks));
        }
    }
}
