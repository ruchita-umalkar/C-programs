// ============================================
// Program #24 — QueueOperations
// Category  : 03_Intermediate
// Difficulty: Intermediate
// Description: Demonstrate queue enqueue, dequeue, and peek operations
// ============================================

using System;
using System.Collections.Generic;

namespace CSharp30Programs.Intermediate
{
    class Program_24_QueueOperations
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            Console.WriteLine("Queue contents: " + string.Join(", ", queue));
            int dequeued = queue.Dequeue();
            Console.WriteLine($"Dequeued: {dequeued}");
            Console.WriteLine($"Next in queue: {queue.Peek()}");
            Console.WriteLine("Queue now: " + string.Join(", ", queue));
        }
    }
}
