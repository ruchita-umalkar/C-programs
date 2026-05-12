// ============================================
// Program #264 — PascalTriangle
// Category  : 27_Number_Algorithms
// Difficulty: Intermediate
// Description: Generate Pascal triangle up to N rows.
// ============================================

using System;

namespace CSharp30Programs.NumberAlgorithms
{
    class Program_264_PascalTriangle
    {
        static void Main(string[] args)
        {
            int n = 6;
            Console.WriteLine($"Pascal Triangle ({n} rows):");

            int[][] triangle = new int[n][];
            for (int i = 0; i < n; i++)
            {
                triangle[i] = new int[i + 1];
                triangle[i][0] = triangle[i][i] = 1;

                for (int j = 1; j < i; j++)
                    triangle[i][j] = triangle[i - 1][j - 1] + triangle[i - 1][j];

                Console.WriteLine(string.Join(" ", triangle[i]));
            }
        }
    }
}
