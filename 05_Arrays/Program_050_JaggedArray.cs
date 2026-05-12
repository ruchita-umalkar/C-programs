// ============================================
// Program #050 — JaggedArray
// Category  : 05_Arrays
// Difficulty: Intermediate
// Description: Declare and iterate a jagged array with different row sizes
// ============================================

using System;

namespace CSharp30Programs.Arrays
{
    class Program_050_JaggedArray
    {
        static void Main(string[] args)
        {
            int[][] jagged = new int[][]
            {
                new int[] { 1, 2 },
                new int[] { 3, 4, 5 },
                new int[] { 6 }
            };

            for (int i = 0; i < jagged.Length; i++)
            {
                Console.Write($"Row {i}: ");
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    Console.Write(jagged[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
