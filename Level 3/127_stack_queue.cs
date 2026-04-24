// Program to demonstrate Stack and Queue 
using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        // Demonstrating Stack
        Stack<string> stack = new Stack<string>();
        stack.Push("Apple");
        stack.Push("Banana");
        stack.Push("Cherry");

        Console.WriteLine("Stack contents:");
        while (stack.Count > 0)
        {
            Console.WriteLine(stack.Pop());
        }

        // Demonstrating Queue
        Queue<string> queue = new Queue<string>();
        queue.Enqueue("Apple");
        queue.Enqueue("Banana");
        queue.Enqueue("Cherry");

        Console.WriteLine("Queue contents:");
        while (queue.Count > 0)
        {
            Console.WriteLine(queue.Dequeue());
        }
    }
}
