// ============================================
// Program #137 — GenericStack
// Category  : 14_Generics
// Difficulty: Intermediate
// Description: Use generic Stack<T> for push and pop operations
// ============================================

using System;

namespace CSharp30Programs.Generics
{
    class Program_137_GenericStack
    {
        static void Main(string[] args)
        {
            System.Collections.Generic.Stack<string> tasks = new System.Collections.Generic.Stack<string>();
            tasks.Push("Code");
            tasks.Push("Compile");
            tasks.Push("Run");

            Console.WriteLine($"Top task: {tasks.Peek()}");
            Console.WriteLine($"Completed: {tasks.Pop()}");
            Console.WriteLine($"Remaining: {tasks.Count}");
        }


    }
}
