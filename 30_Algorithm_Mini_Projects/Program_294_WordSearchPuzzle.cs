// ============================================
// Program #294 — WordSearchPuzzle
// Category  : 30_Algorithm_Mini_Projects
// Difficulty: [Intermediate]
// Description: Finds words in a 2D character grid horizontally and vertically.
// ============================================

using System;

namespace CSharp30Programs.AlgorithmMiniProjects
{
    class Program_294_WordSearchPuzzle
    {
        static void Main(string[] args)
        {
            char[,] grid =
            {
                {'C','O','D','E','X'},
                {'A','R','R','A','Y'},
                {'S','T','A','C','K'},
                {'Q','U','E','U','E'},
                {'L','I','N','Q','S'}
            };
            string[] words = { "CODE", "STACK", "QUEUE", "LINQ", "TREE" };
            foreach (var w in words) Console.WriteLine($"{w}: {(Find(grid, w) ? "Found" : "Not Found")}");
        }

        static bool Find(char[,] g, string word)
        {
            int r = g.GetLength(0), c = g.GetLength(1);
            for (int i = 0; i < r; i++)
                for (int j = 0; j < c; j++)
                    if (Match(g, word, i, j, 0, 1) || Match(g, word, i, j, 1, 0)) return true;
            return false;
        }

        static bool Match(char[,] g, string w, int r, int c, int dr, int dc)
        {
            for (int k = 0; k < w.Length; k++)
            {
                int nr = r + dr * k, nc = c + dc * k;
                if (nr < 0 || nr >= g.GetLength(0) || nc < 0 || nc >= g.GetLength(1) || g[nr, nc] != w[k]) return false;
            }
            return true;
        }
    }
}
