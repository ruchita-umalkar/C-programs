// ============================================
// Program #213 — LinkedListFromScratch
// Category  : 22_Data_Structures
// Difficulty: Intermediate
// Description: Singly linked list with insert/delete/traverse
// ============================================

using System;

namespace CSharp30Programs.DataStructures
{
    class Program_213_LinkedListFromScratch
    {
        static void Main(string[] args)
        {
            Node head = null;

            void InsertEnd(int value)
            {
                Node node = new Node(value);
                if (head == null)
                {
                    head = node;
                    return;
                }
                Node current = head;
                while (current.Next != null) current = current.Next;
                current.Next = node;
            }

            bool Delete(int value)
            {
                if (head == null) return false;
                if (head.Value == value)
                {
                    head = head.Next;
                    return true;
                }

                Node current = head;
                while (current.Next != null && current.Next.Value != value)
                    current = current.Next;

                if (current.Next == null) return false;
                current.Next = current.Next.Next;
                return true;
            }

            void Traverse()
            {
                Node current = head;
                Console.Write("List: ");
                while (current != null)
                {
                    Console.Write(current.Value + (current.Next != null ? " -> " : ""));
                    current = current.Next;
                }
                Console.WriteLine();
            }

            InsertEnd(1); InsertEnd(2); InsertEnd(3); InsertEnd(4);
            Traverse();
            Console.WriteLine($"Delete 3: {Delete(3)}");
            Traverse();


        }
    }
    class Node
    {
        public int Value;
        public Node Next;
        public Node(int value) { Value = value; }
    }

}
