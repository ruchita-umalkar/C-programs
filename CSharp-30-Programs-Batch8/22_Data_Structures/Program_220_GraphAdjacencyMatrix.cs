// ============================================
// Program #220 — GraphAdjacencyMatrix
// Category  : 22_Data_Structures
// Difficulty: Intermediate
// Description: Graph using adjacency matrix with DFS traversal
// ============================================

using System;

namespace CSharp30Programs.DataStructures
{
    class Program_220_GraphAdjacencyMatrix
    {
        static void Main(string[] args)
        {
            int vertices = 5;
            int[,] matrix = new int[vertices, vertices];

            void AddEdge(int u, int v)
            {
                matrix[u, v] = 1;
                matrix[v, u] = 1;
            }

            void DFS(int node, bool[] visited)
            {
                visited[node] = true;
                Console.Write(node + " ");

                for (int i = 0; i < vertices; i++)
                {
                    if (matrix[node, i] == 1 && !visited[i])
                        DFS(i, visited);
                }
            }

            AddEdge(0, 1); AddEdge(0, 2); AddEdge(1, 3); AddEdge(2, 4);
            Console.Write("DFS: ");
            DFS(0, new bool[vertices]);
            Console.WriteLine();

        }
    }
}
