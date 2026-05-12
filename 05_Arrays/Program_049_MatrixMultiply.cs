// ============================================
// Program #049 — MatrixMultiply
// Category  : 05_Arrays
// Difficulty: Intermediate
// Description: Multiply two 3x3 matrices
// ============================================

using System;

namespace CSharp30Programs.Arrays
{
    class Program_049_MatrixMultiply
    {
        static void Main(string[] args)
        {
            int[,] a =
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            int[,] b =
            {
                { 9, 8, 7 },
                { 6, 5, 4 },
                { 3, 2, 1 }
            };

            int[,] result = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        result[i, j] += a[i, k] * b[k, j];
                    }
                }
            }

            Console.WriteLine("Result matrix:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(result[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
