// ============================================
// Program #048 — 2DArrayMatrix
// Category  : 05_Arrays
// Difficulty: Intermediate
// Description: Create and display a 2D matrix and find sum of rows
// ============================================

using System;

namespace CSharp30Programs.Arrays
{
    class Program_048_2DArrayMatrix
    {
        static void Main(string[] args)
        {
            int[,] matrix =
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            Console.WriteLine("Matrix:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int rowSum = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                    rowSum += matrix[i, j];
                }
                Console.WriteLine($"=> Row Sum: {rowSum}");
            }
        }
    }
}
