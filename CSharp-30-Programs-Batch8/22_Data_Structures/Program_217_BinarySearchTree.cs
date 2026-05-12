// ============================================
// Program #217 — BinarySearchTree
// Category  : 22_Data_Structures
// Difficulty: Intermediate
// Description: BST with insert, search, delete operations
// ============================================

using System;

namespace CSharp30Programs.DataStructures
{
    class Program_217_BinarySearchTree
    {
        static void Main(string[] args)
        {
            Node root = null;

            Node Insert(Node node, int value)
            {
                if (node == null) return new Node(value);
                if (value < node.Value) node.Left = Insert(node.Left, value);
                else if (value > node.Value) node.Right = Insert(node.Right, value);
                return node;
            }

            bool Search(Node node, int value)
            {
                if (node == null) return false;
                if (node.Value == value) return true;
                return value < node.Value ? Search(node.Left, value) : Search(node.Right, value);
            }

            Node Min(Node node)
            {
                while (node.Left != null) node = node.Left;
                return node;
            }

            Node Delete(Node node, int value)
            {
                if (node == null) return null;
                if (value < node.Value) node.Left = Delete(node.Left, value);
                else if (value > node.Value) node.Right = Delete(node.Right, value);
                else
                {
                    if (node.Left == null) return node.Right;
                    if (node.Right == null) return node.Left;
                    Node succ = Min(node.Right);
                    node.Value = succ.Value;
                    node.Right = Delete(node.Right, succ.Value);
                }
                return node;
            }

            void Inorder(Node node)
            {
                if (node == null) return;
                Inorder(node.Left);
                Console.Write(node.Value + " ");
                Inorder(node.Right);
            }

            int[] values = { 50, 30, 70, 20, 40, 60, 80 };
            foreach (int v in values) root = Insert(root, v);
            Console.Write("BST Inorder: "); Inorder(root); Console.WriteLine();
            Console.WriteLine($"Search 60: {Search(root, 60)}");
            root = Delete(root, 70);
            Console.Write("After deleting 70: "); Inorder(root); Console.WriteLine();

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
