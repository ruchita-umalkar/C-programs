// ============================================
// Program #298 — FloodFillAlgorithm
// Category  : 30_Algorithm_Mini_Projects
// Difficulty: [Intermediate]
// Description: Applies flood fill to a 2D grid from a start cell.
// ============================================

using System;

namespace CSharp30Programs.AlgorithmMiniProjects
{
    class Program_298_FloodFillAlgorithm
    {
        static void Main(string[] args)
        {
            int[,] grid =
            {
                {1,1,1,2,2},
                {1,1,0,2,2},
                {1,0,0,2,2},
                {2,2,2,2,2}
            };
            Console.WriteLine("Before fill:");
            Print(grid);
            FloodFill(grid, 1, 1, 9);
            Console.WriteLine("After fill:");
            Print(grid);
        }

        static void FloodFill(int[,] g, int sr, int sc, int newColor)
        {
            int old = g[sr, sc];
            if (old == newColor) return;
            Fill(g, sr, sc, old, newColor);
        }

        static void Fill(int[,] g, int r, int c, int oldColor, int newColor)
        {
            if (r < 0 || c < 0 || r >= g.GetLength(0) || c >= g.GetLength(1) || g[r, c] != oldColor) return;
            g[r, c] = newColor;
            Fill(g, r + 1, c, oldColor, newColor);
            Fill(g, r - 1, c, oldColor, newColor);
            Fill(g, r, c + 1, oldColor, newColor);
            Fill(g, r, c - 1, oldColor, newColor);
        }

        static void Print(int[,] g)
        {
            for (int i = 0; i < g.GetLength(0); i++)
            {
                for (int j = 0; j < g.GetLength(1); j++) Console.Write(g[i, j] + " ");
                Console.WriteLine();
            }
        }
    }
}
