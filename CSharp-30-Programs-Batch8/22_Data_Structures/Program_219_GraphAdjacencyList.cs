// ============================================
// Program #219 — GraphAdjacencyList
// Category  : 22_Data_Structures
// Difficulty: Intermediate
// Description: Graph using adjacency list with BFS traversal
// ============================================

using System;

namespace CSharp30Programs.DataStructures
{
    class Program_219_GraphAdjacencyList
    {
        static void Main(string[] args)
        {
            int vertices = 6;
            var graph = new System.Collections.Generic.List<int>[vertices];
            for (int i = 0; i < vertices; i++) graph[i] = new System.Collections.Generic.List<int>();

            void AddEdge(int u, int v)
            {
                graph[u].Add(v);
                graph[v].Add(u);
            }

            void BFS(int start)
            {
                bool[] visited = new bool[vertices];
                var queue = new System.Collections.Generic.Queue<int>();

                visited[start] = true;
                queue.Enqueue(start);

                Console.Write("BFS: ");
                while (queue.Count > 0)
                {
                    int node = queue.Dequeue();
                    Console.Write(node + " ");

                    foreach (int next in graph[node])
                    {
                        if (!visited[next])
                        {
                            visited[next] = true;
                            queue.Enqueue(next);
                        }
                    }
                }
                Console.WriteLine();
            }

            AddEdge(0, 1); AddEdge(0, 2); AddEdge(1, 3); AddEdge(2, 4); AddEdge(3, 5);
            BFS(0);

        }
    }
}
