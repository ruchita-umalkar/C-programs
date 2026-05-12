// ============================================
// Program #214 — DoublyLinkedList
// Category  : 22_Data_Structures
// Difficulty: Intermediate
// Description: Doubly linked list with forward/backward traversal
// ============================================

using System;

namespace CSharp30Programs.DataStructures
{
    class Program_214_DoublyLinkedList
    {
        static void Main(string[] args)
        {
            Node head = null, tail = null;

            void InsertEnd(int value)
            {
                Node node = new Node(value);
                if (head == null)
                {
                    head = tail = node;
                    return;
                }
                tail.Next = node;
                node.Prev = tail;
                tail = node;
            }

            void TraverseForward()
            {
                Console.Write("Forward: ");
                Node current = head;
                while (current != null)
                {
                    Console.Write(current.Value + (current.Next != null ? " <-> " : ""));
                    current = current.Next;
                }
                Console.WriteLine();
            }

            void TraverseBackward()
            {
                Console.Write("Backward: ");
                Node current = tail;
                while (current != null)
                {
                    Console.Write(current.Value + (current.Prev != null ? " <-> " : ""));
                    current = current.Prev;
                }
                Console.WriteLine();
            }

            InsertEnd(10); InsertEnd(20); InsertEnd(30);
            TraverseForward();
            TraverseBackward();

        }
    }
    class Node
    {
        public int Value;
        public Node Prev;
        public Node Next;
        public Node(int value) { Value = value; }
    }

}
