// ============================================
// Program #266 — ArmstrongNumbers
// Category  : 27_Number_Algorithms
// Difficulty: Intermediate
// Description: Find all Armstrong numbers between 1 and 1000.
// ============================================

using System;

namespace CSharp30Programs.NumberAlgorithms
{
    class Program_266_ArmstrongNumbers
    {
        static bool IsArmstrong(int n)
        {
            int temp = n;
            int digits = n.ToString().Length;
            int sum = 0;

            while (temp > 0)
            {
                int digit = temp % 10;
                sum += (int)Math.Pow(digit, digits);
                temp /= 10;
            }

            return sum == n;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Armstrong numbers from 1 to 1000:");
            for (int i = 1; i <= 1000; i++)
            {
                if (IsArmstrong(i)) Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
