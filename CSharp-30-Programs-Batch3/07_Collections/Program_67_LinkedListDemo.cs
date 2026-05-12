// ============================================
// Program #67 — LinkedListDemo
// Category  : 07_Collections
// Difficulty: Intermediate
// Description: Insert and traverse nodes using LinkedList
// ============================================

using System;
using System.Collections.Generic;

namespace CSharp30Programs._07_Collections
{
    class Program_67_LinkedListDemo
    {
        static void Main(string[] args)
        {
            var stations = new LinkedList<string>();
            stations.AddLast("Station A");
            stations.AddLast("Station C");
            var nodeC = stations.Find("Station C");
            if (nodeC != null)
            {
                stations.AddBefore(nodeC, "Station B");
            }
            Console.WriteLine($"Route: {string.Join(" -> ", stations)}");
        }
    }
}
