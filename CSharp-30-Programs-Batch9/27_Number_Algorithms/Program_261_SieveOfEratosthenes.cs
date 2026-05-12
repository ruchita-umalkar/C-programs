// ============================================
// Program #261 — SieveOfEratosthenes
// Category  : 27_Number_Algorithms
// Difficulty: Intermediate
// Description: Find all prime numbers up to N using Sieve of Eratosthenes.
// ============================================

using System;

namespace CSharp30Programs.NumberAlgorithms
{
    class Program_261_SieveOfEratosthenes
    {
        static void Main(string[] args)
        {
            int n = 50;
            bool[] prime = new bool[n + 1];
            for (int i = 2; i <= n; i++) prime[i] = true;

            for (int p = 2; p * p <= n; p++)
            {
                if (prime[p])
                {
                    for (int i = p * p; i <= n; i += p)
                        prime[i] = false;
                }
            }

            Console.WriteLine($"Primes up to {n}:");
            for (int i = 2; i <= n; i++)
                if (prime[i]) Console.Write(i + " ");
            Console.WriteLine();
        }
    }
}
