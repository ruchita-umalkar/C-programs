// ============================================
// Program #300 — MazeSolver
// Category  : 30_Algorithm_Mini_Projects
// Difficulty: [Intermediate]
// Description: Solves a maze using recursive DFS backtracking.
// ============================================

using System;

namespace CSharp30Programs.AlgorithmMiniProjects
{
    class Program_300_MazeSolver
    {
        static void Main(string[] args)
        {
            int[,] maze =
            {
                {0,1,0,0,0},
                {0,1,0,1,0},
                {0,0,0,1,0},
                {1,1,0,1,0},
                {0,0,0,0,0}
            };
            bool[,] path = new bool[5,5];
            bool solved = Solve(maze, 0, 0, 4, 4, path);
            Console.WriteLine(solved ? "Maze solved. Path marked with *" : "No path found.");
            Print(maze, path);
        }

        static bool Solve(int[,] m, int r, int c, int tr, int tc, bool[,] path)
        {
            if (r < 0 || c < 0 || r >= m.GetLength(0) || c >= m.GetLength(1) || m[r, c] == 1 || path[r, c]) return false;
            path[r, c] = true;
            if (r == tr && c == tc) return true;
            if (Solve(m, r + 1, c, tr, tc, path) || Solve(m, r - 1, c, tr, tc, path) || Solve(m, r, c + 1, tr, tc, path) || Solve(m, r, c - 1, tr, tc, path)) return true;
            path[r, c] = false;
            return false;
        }

        static void Print(int[,] m, bool[,] path)
        {
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    if (path[i, j]) Console.Write("* ");
                    else Console.Write(m[i, j] == 1 ? "# " : ". ");
                }
                Console.WriteLine();
            }
        }
    }
}
