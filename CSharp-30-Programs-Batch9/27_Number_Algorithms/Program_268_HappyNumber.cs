// ============================================
// Program #268 — HappyNumber
// Category  : 27_Number_Algorithms
// Difficulty: Intermediate
// Description: Check if a number is happy using cycle detection.
// ============================================

using System;
using System.Collections.Generic;

namespace CSharp30Programs.NumberAlgorithms
{
    class Program_268_HappyNumber
    {
        static int SumOfSquares(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int d = n % 10;
                sum += d * d;
                n /= 10;
            }
            return sum;
        }

        static bool IsHappy(int n)
        {
            HashSet<int> seen = new HashSet<int>();
            while (n != 1 && !seen.Contains(n))
            {
                seen.Add(n);
                n = SumOfSquares(n);
            }
            return n == 1;
        }

        static void Main(string[] args)
        {
            int number = 19;
            Console.WriteLine($"{number} is happy: {IsHappy(number)}");
        }
    }
}
