// ============================================
// Program #103 — GCDAndLCM
// Category  : 11_Math_Operations
// Difficulty: Basic
// Description: Calculate GCD and LCM of two integers
// ============================================

using System;

namespace CSharp30Programs.MathOperations
{
    class Program_103_GCDAndLCM
    {
        static void Main(string[] args)
        {
            int a = 48;
            int b = 18;
            int x = a;
            int y = b;
            while (y != 0)
            {
                int temp = y;
                y = x % y;
                x = temp;
            }
            int gcd = x;
            int lcm = (a * b) / gcd;
            Console.WriteLine($"Number 1: {a}");
            Console.WriteLine($"Number 2: {b}");
            Console.WriteLine($"GCD: {gcd}");
            Console.WriteLine($"LCM: {lcm}");
        }
    }
}
