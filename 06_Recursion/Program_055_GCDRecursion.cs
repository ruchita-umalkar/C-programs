// ============================================
// Program #055 — GCDRecursion
// Category  : 06_Recursion
// Difficulty: Intermediate
// Description: GCD of two numbers using Euclidean recursion
// ============================================

using System;

namespace CSharp30Programs.Recursion
{
    class Program_055_GCDRecursion
    {
        static void Main(string[] args)
        {
            int a = 48;
            int b = 18;
            Console.WriteLine($"GCD of {a} and {b} is {Gcd(a, b)}");
        }

        static int Gcd(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }
            return Gcd(b, a % b);
        }
    }
}
