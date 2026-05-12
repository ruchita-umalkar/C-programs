// ============================================
// Program #211 — StackFromScratch
// Category  : 22_Data_Structures
// Difficulty: Intermediate
// Description: Stack using array with push/pop/peek/isEmpty
// ============================================

using System;

namespace CSharp30Programs.DataStructures
{
    class Program_211_StackFromScratch
    {
        static void Main(string[] args)
        {
            int[] data = new int[5];
            int top = -1;

            void Push(int value)
            {
                if (top == data.Length - 1)
                {
                    Console.WriteLine("Push failed: stack overflow");
                    return;
                }
                data[++top] = value;
                Console.WriteLine($"Pushed: {value}");
            }

            int Pop()
            {
                if (top == -1)
                {
                    Console.WriteLine("Pop failed: stack underflow");
                    return -1;
                }
                return data[top--];
            }

            int Peek() => top == -1 ? -1 : data[top];
            bool IsEmpty() => top == -1;

            Push(10);
            Push(20);
            Push(30);
            Console.WriteLine($"Peek: {Peek()}");
            Console.WriteLine($"Popped: {Pop()}");
            Console.WriteLine($"Popped: {Pop()}");
            Console.WriteLine($"IsEmpty: {IsEmpty()}");
            Console.WriteLine($"Popped: {Pop()}");
            Console.WriteLine($"IsEmpty: {IsEmpty()}");

        }
    }
}
