// ============================================
// Program #297 — NumberPuzzle2048
// Category  : 30_Algorithm_Mini_Projects
// Difficulty: [Intermediate]
// Description: Simplified 2048 puzzle logic with movement and merge scoring.
// ============================================

using System;

namespace CSharp30Programs.AlgorithmMiniProjects
{
    class Program_297_NumberPuzzle2048
    {
        static void Main(string[] args)
        {
            int[] row = { 2, 0, 2, 4 };
            int score = 0;
            Console.WriteLine("Simplified 2048 (single row demo)");
            Show(row, score);
            while (true)
            {
                Console.Write("Move (L/R) or Q: ");
                string c = (Console.ReadLine() ?? "").Trim().ToUpper();
                if (c == "Q") break;
                if (c != "L" && c != "R") continue;
                if (c == "R") Array.Reverse(row);
                Compact(row);
                for (int i = 0; i < row.Length - 1; i++)
                {
                    if (row[i] != 0 && row[i] == row[i + 1])
                    {
                        row[i] *= 2;
                        score += row[i];
                        row[i + 1] = 0;
                    }
                }
                Compact(row);
                if (c == "R") Array.Reverse(row);
                AddRandomTwo(row);
                Show(row, score);
            }
            Console.WriteLine("Game ended.");
        }

        static void Compact(int[] a)
        {
            int p = 0;
            for (int i = 0; i < a.Length; i++) if (a[i] != 0) { int t = a[i]; a[i] = 0; a[p++] = t; }
        }

        static void AddRandomTwo(int[] a)
        {
            var empty = new System.Collections.Generic.List<int>();
            for (int i = 0; i < a.Length; i++) if (a[i] == 0) empty.Add(i);
            if (empty.Count == 0) return;
            int idx = empty[new Random().Next(empty.Count)];
            a[idx] = 2;
        }

        static void Show(int[] a, int score)
        {
            Console.WriteLine($"[{a[0]}, {a[1]}, {a[2]}, {a[3]}] Score={score}");
        }
    }
}
