// ============================================
// Program #216 — BinaryTree
// Category  : 22_Data_Structures
// Difficulty: Intermediate
// Description: Binary tree with insert, inorder/preorder/postorder
// ============================================

using System;

namespace CSharp30Programs.DataStructures
{
    class Program_216_BinaryTree
    {
        static void Main(string[] args)
        {
            Node root = null;

            void Insert(int value)
            {
                Node node = new Node(value);
                if (root == null)
                {
                    root = node;
                    return;
                }

                var queue = new System.Collections.Generic.Queue<Node>();
                queue.Enqueue(root);
                while (queue.Count > 0)
                {
                    Node current = queue.Dequeue();
                    if (current.Left == null)
                    {
                        current.Left = node;
                        return;
                    }
                    if (current.Right == null)
                    {
                        current.Right = node;
                        return;
                    }
                    queue.Enqueue(current.Left);
                    queue.Enqueue(current.Right);
                }
            }

            void Inorder(Node n)
            {
                if (n == null) return;
                Inorder(n.Left);
                Console.Write(n.Value + " ");
                Inorder(n.Right);
            }

            void Preorder(Node n)
            {
                if (n == null) return;
                Console.Write(n.Value + " ");
                Preorder(n.Left);
                Preorder(n.Right);
            }

            void Postorder(Node n)
            {
                if (n == null) return;
                Postorder(n.Left);
                Postorder(n.Right);
                Console.Write(n.Value + " ");
            }

            Insert(1); Insert(2); Insert(3); Insert(4); Insert(5);
            Console.Write("Inorder: "); Inorder(root); Console.WriteLine();
            Console.Write("Preorder: "); Preorder(root); Console.WriteLine();
            Console.Write("Postorder: "); Postorder(root); Console.WriteLine();

        }
    }
    class Node
    {
        public int Value;
        public Node Left;
        public Node Right;
        public Node(int value) { Value = value; }
    }

}
