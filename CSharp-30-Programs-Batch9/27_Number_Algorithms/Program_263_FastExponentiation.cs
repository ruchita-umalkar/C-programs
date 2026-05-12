// ============================================
// Program #263 — FastExponentiation
// Category  : 27_Number_Algorithms
// Difficulty: Intermediate
// Description: Compute x^n using binary exponentiation efficiently.
// ============================================

using System;

namespace CSharp30Programs.NumberAlgorithms
{
    class Program_263_FastExponentiation
    {
        static long Power(long x, long n)
        {
            long result = 1;
            while (n > 0)
            {
                if ((n & 1) == 1) result *= x;
                x *= x;
                n >>= 1;
            }
            return result;
        }

        static void Main(string[] args)
        {
            long x = 3, n = 13;
            Console.WriteLine($"{x}^{n} = {Power(x, n)}");
        }
    }
}
