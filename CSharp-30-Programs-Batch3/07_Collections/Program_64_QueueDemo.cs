// ============================================
// Program #64 — QueueDemo
// Category  : 07_Collections
// Difficulty: Basic
// Description: Demonstrate FIFO operations using Queue
// ============================================

using System;
using System.Collections.Generic;

namespace CSharp30Programs._07_Collections
{
    class Program_64_QueueDemo
    {
        static void Main(string[] args)
        {
            var queue = new Queue<string>();
            queue.Enqueue("Task A");
            queue.Enqueue("Task B");
            queue.Enqueue("Task C");
            string first = queue.Dequeue();
            Console.WriteLine($"Processed: {first}");
            Console.WriteLine($"Next in queue: {queue.Peek()}");
            Console.WriteLine($"Remaining: {string.Join(", ", queue)}");
        }
    }
}
