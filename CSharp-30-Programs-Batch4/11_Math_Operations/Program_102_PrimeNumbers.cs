// ============================================
// Program #102 — PrimeNumbers
// Category  : 11_Math_Operations
// Difficulty: Basic
// Description: Print all prime numbers between 1 and 100
// ============================================

using System;

namespace CSharp30Programs.MathOperations
{
    class Program_102_PrimeNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prime Numbers from 1 to 100:");
            for (int i = 2; i <= 100; i++)
            {
                bool isPrime = true;
                for (int j = 2; j * j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
