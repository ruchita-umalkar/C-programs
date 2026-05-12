// ============================================
// Program #262 — EuclideanGCD
// Category  : 27_Number_Algorithms
// Difficulty: Intermediate
// Description: Compute GCD using extended Euclidean algorithm and print steps.
// ============================================

using System;

namespace CSharp30Programs.NumberAlgorithms
{
    class Program_262_EuclideanGCD
    {
        static (int gcd, int x, int y) ExtendedGcd(int a, int b)
        {
            if (b == 0) return (a, 1, 0);
            var next = ExtendedGcd(b, a % b);
            int x = next.y;
            int y = next.x - (a / b) * next.y;
            return (next.gcd, x, y);
        }

        static void Main(string[] args)
        {
            int a = 99, b = 78;
            Console.WriteLine($"Calculating gcd({a}, {b}) with Euclidean steps:");
            int ta = a, tb = b;
            while (tb != 0)
            {
                Console.WriteLine($"{ta} = {tb} * {ta / tb} + {ta % tb}");
                int t = ta % tb;
                ta = tb;
                tb = t;
            }

            var result = ExtendedGcd(a, b);
            Console.WriteLine($"GCD = {result.gcd}, x = {result.x}, y = {result.y}");
            Console.WriteLine($"Verification: {a}*({result.x}) + {b}*({result.y}) = {a * result.x + b * result.y}");
        }
    }
}
