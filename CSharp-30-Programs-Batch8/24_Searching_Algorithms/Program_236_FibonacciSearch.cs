// ============================================
// Program #236 — FibonacciSearch
// Category  : 24_Searching_Algorithms
// Difficulty: Intermediate
// Description: Fibonacci search using Fibonacci numbers as index
// ============================================

using System;

namespace CSharp30Programs.SearchingAlgorithms
{
    class Program_236_FibonacciSearch
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 22, 35, 40, 45, 50, 80, 82, 85, 90, 100 };
            int target = 85;
            int n = arr.Length;

            int fibMm2 = 0;
            int fibMm1 = 1;
            int fibM = fibMm1 + fibMm2;

            while (fibM < n)
            {
                fibMm2 = fibMm1;
                fibMm1 = fibM;
                fibM = fibMm1 + fibMm2;
            }

            int offset = -1;
            while (fibM > 1)
            {
                int i = System.Math.Min(offset + fibMm2, n - 1);
                Console.WriteLine($"Compare at index {i}, value {arr[i]}");

                if (arr[i] < target)
                {
                    fibM = fibMm1;
                    fibMm1 = fibMm2;
                    fibMm2 = fibM - fibMm1;
                    offset = i;
                }
                else if (arr[i] > target)
                {
                    fibM = fibMm2;
                    fibMm1 = fibMm1 - fibMm2;
                    fibMm2 = fibM - fibMm1;
                }
                else
                {
                    Console.WriteLine($"Found at index {i}");
                    return;
                }
            }

            if (fibMm1 == 1 && offset + 1 < n && arr[offset + 1] == target)
            {
                Console.WriteLine($"Found at index {offset + 1}");
                return;
            }

            Console.WriteLine("Not found");

        }
    }
}
