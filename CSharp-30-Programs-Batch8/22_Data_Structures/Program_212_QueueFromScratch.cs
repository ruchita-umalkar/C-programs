// ============================================
// Program #212 — QueueFromScratch
// Category  : 22_Data_Structures
// Difficulty: Intermediate
// Description: Queue using array with enqueue/dequeue/peek
// ============================================

using System;

namespace CSharp30Programs.DataStructures
{
    class Program_212_QueueFromScratch
    {
        static void Main(string[] args)
        {
            int[] data = new int[5];
            int front = 0, rear = -1, size = 0;

            void Enqueue(int value)
            {
                if (size == data.Length)
                {
                    Console.WriteLine("Enqueue failed: queue full");
                    return;
                }
                rear = (rear + 1) % data.Length;
                data[rear] = value;
                size++;
                Console.WriteLine($"Enqueued: {value}");
            }

            int Dequeue()
            {
                if (size == 0)
                {
                    Console.WriteLine("Dequeue failed: queue empty");
                    return -1;
                }
                int value = data[front];
                front = (front + 1) % data.Length;
                size--;
                return value;
            }

            int Peek() => size == 0 ? -1 : data[front];

            Enqueue(5);
            Enqueue(15);
            Enqueue(25);
            Console.WriteLine($"Peek: {Peek()}");
            Console.WriteLine($"Dequeued: {Dequeue()}");
            Console.WriteLine($"Dequeued: {Dequeue()}");
            Console.WriteLine($"Peek: {Peek()}");

        }
    }
}
