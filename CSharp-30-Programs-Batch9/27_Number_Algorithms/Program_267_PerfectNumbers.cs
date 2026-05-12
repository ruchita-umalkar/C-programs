// ============================================
// Program #267 — PerfectNumbers
// Category  : 27_Number_Algorithms
// Difficulty: Intermediate
// Description: Find perfect numbers up to N and display their proper factors.
// ============================================

using System;
using System.Collections.Generic;

namespace CSharp30Programs.NumberAlgorithms
{
    class Program_267_PerfectNumbers
    {
        static void Main(string[] args)
        {
            int n = 1000;
            Console.WriteLine($"Perfect numbers up to {n}:");

            for (int num = 2; num <= n; num++)
            {
                List<int> factors = new List<int> { 1 };
                int sum = 1;

                for (int i = 2; i * i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        factors.Add(i);
                        sum += i;
                        if (i != num / i)
                        {
                            factors.Add(num / i);
                            sum += num / i;
                        }
                    }
                }

                if (num == 1) sum = 0;

                if (sum == num && num != 1)
                {
                    factors.Sort();
                    Console.WriteLine($"{num} = {string.Join(" + ", factors)}");
                }
            }
        }
    }
}
