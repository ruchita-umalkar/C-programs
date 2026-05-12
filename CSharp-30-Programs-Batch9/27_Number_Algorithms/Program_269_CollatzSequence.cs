// ============================================
// Program #269 — CollatzSequence
// Category  : 27_Number_Algorithms
// Difficulty: Intermediate
// Description: Generate Collatz sequence from a number until it reaches 1.
// ============================================

using System;

namespace CSharp30Programs.NumberAlgorithms
{
    class Program_269_CollatzSequence
    {
        static void Main(string[] args)
        {
            int n = 27;
            Console.WriteLine($"Collatz sequence for {n}:");

            while (n != 1)
            {
                Console.Write(n + " -> ");
                n = n % 2 == 0 ? n / 2 : 3 * n + 1;
            }
            Console.WriteLine("1");
        }
    }
}
