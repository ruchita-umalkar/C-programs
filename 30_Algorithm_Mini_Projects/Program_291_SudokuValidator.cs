// ============================================
// Program #291 — SudokuValidator
// Category  : 30_Algorithm_Mini_Projects
// Difficulty: [Intermediate]
// Description: Validates rows, columns, and 3x3 boxes of a Sudoku board.
// ============================================

using System;

namespace CSharp30Programs.AlgorithmMiniProjects
{
    class Program_291_SudokuValidator
    {
        static void Main(string[] args)
        {
            int[,] board =
            {
                {5,3,4,6,7,8,9,1,2},
                {6,7,2,1,9,5,3,4,8},
                {1,9,8,3,4,2,5,6,7},
                {8,5,9,7,6,1,4,2,3},
                {4,2,6,8,5,3,7,9,1},
                {7,1,3,9,2,4,8,5,6},
                {9,6,1,5,3,7,2,8,4},
                {2,8,7,4,1,9,6,3,5},
                {3,4,5,2,8,6,1,7,9}
            };
            Console.WriteLine(IsValidSudoku(board) ? "Sudoku board is valid." : "Sudoku board is invalid.");
        }

        static bool IsValidSudoku(int[,] b)
        {
            for (int i = 0; i < 9; i++)
            {
                var row = new bool[10];
                var col = new bool[10];
                for (int j = 0; j < 9; j++)
                {
                    int r = b[i, j], c = b[j, i];
                    if (r < 1 || r > 9 || row[r]) return false; row[r] = true;
                    if (c < 1 || c > 9 || col[c]) return false; col[c] = true;
                }
            }

            for (int br = 0; br < 9; br += 3)
                for (int bc = 0; bc < 9; bc += 3)
                {
                    var seen = new bool[10];
                    for (int r = br; r < br + 3; r++)
                        for (int c = bc; c < bc + 3; c++)
                        {
                            int v = b[r, c];
                            if (seen[v]) return false;
                            seen[v] = true;
                        }
                }
            return true;
        }
    }
}
