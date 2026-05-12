// ============================================
// Program #054 — PowerFunction
// Category  : 06_Recursion
// Difficulty: Basic
// Description: Calculate x^n using recursion
// ============================================

using System;

namespace CSharp30Programs.Recursion
{
    class Program_054_PowerFunction
    {
        static void Main(string[] args)
        {
            double x = 2;
            int n = -3;
            Console.WriteLine($"{x}^{n} = {Power(x, n)}");
        }

        static double Power(double x, int n)
        {
            if (n < 0)
            {
                long exponent = -(long)n;
                return 1 / PowerInternal(x, exponent);
            }

            return PowerInternal(x, n);
        }

        static double PowerInternal(double x, long n)
        {
            if (n == 0)
            {
                return 1;
            }

            double half = PowerInternal(x, n / 2);
            if (n % 2 == 0)
            {
                return half * half;
            }

            return x * half * half;
        }
    }
}
