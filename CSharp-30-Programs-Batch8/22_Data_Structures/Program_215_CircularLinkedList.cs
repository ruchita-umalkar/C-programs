// ============================================
// Program #215 — CircularLinkedList
// Category  : 22_Data_Structures
// Difficulty: Intermediate
// Description: Circular linked list with insert and display
// ============================================

using System;

namespace CSharp30Programs.DataStructures
{
    class Program_215_CircularLinkedList
    {
        static void Main(string[] args)
        {
            Node tail = null;

            void Insert(int value)
            {
                Node node = new Node(value);
                if (tail == null)
                {
                    tail = node;
                    tail.Next = tail;
                    return;
                }
                node.Next = tail.Next;
                tail.Next = node;
                tail = node;
            }

            void Display()
            {
                if (tail == null)
                {
                    Console.WriteLine("List is empty");
                    return;
                }
                Console.Write("Circular List: ");
                Node current = tail.Next;
                do
                {
                    Console.Write(current.Value + (current.Next != tail.Next ? " -> " : ""));
                    current = current.Next;
                } while (current != tail.Next);
                Console.WriteLine(" -> (back to head)");
            }

            Insert(11); Insert(22); Insert(33); Insert(44);
            Display();

        }
    }
    class Node
    {
        public int Value;
        public Node Next;
        public Node(int value) { Value = value; }
    }

}
