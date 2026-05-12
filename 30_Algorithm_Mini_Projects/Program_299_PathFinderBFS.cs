// ============================================
// Program #299 — PathFinderBFS
// Category  : 30_Algorithm_Mini_Projects
// Difficulty: [Intermediate]
// Description: Finds shortest path in a 2D maze using BFS.
// ============================================

using System;

namespace CSharp30Programs.AlgorithmMiniProjects
{
    class Program_299_PathFinderBFS
    {
        static void Main(string[] args)
        {
            int[,] maze =
            {
                {0,0,0,1,0},
                {1,1,0,1,0},
                {0,0,0,0,0},
                {0,1,1,1,1},
                {0,0,0,0,0}
            };
            int steps = ShortestPath(maze, 0, 0, 4, 4);
            Console.WriteLine(steps >= 0 ? $"Shortest path length: {steps}" : "No path found.");
        }

        static int ShortestPath(int[,] m, int sr, int sc, int tr, int tc)
        {
            int rows = m.GetLength(0), cols = m.GetLength(1);
            var q = new System.Collections.Generic.Queue<(int r, int c, int d)>();
            var seen = new bool[rows, cols];
            q.Enqueue((sr, sc, 0));
            seen[sr, sc] = true;
            int[] dr = {1,-1,0,0};
            int[] dc = {0,0,1,-1};
            while (q.Count > 0)
            {
                var cur = q.Dequeue();
                if (cur.r == tr && cur.c == tc) return cur.d;
                for (int i = 0; i < 4; i++)
                {
                    int nr = cur.r + dr[i], nc = cur.c + dc[i];
                    if (nr >= 0 && nc >= 0 && nr < rows && nc < cols && !seen[nr, nc] && m[nr, nc] == 0)
                    {
                        seen[nr, nc] = true;
                        q.Enqueue((nr, nc, cur.d + 1));
                    }
                }
            }
            return -1;
        }
    }
}
