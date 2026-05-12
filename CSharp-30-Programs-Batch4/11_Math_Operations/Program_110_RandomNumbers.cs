// ============================================
// Program #110 — RandomNumbers
// Category  : 11_Math_Operations
// Difficulty: Basic
// Description: Generate random numbers with dice and coin simulations
// ============================================

using System;

namespace CSharp30Programs.MathOperations
{
    class Program_110_RandomNumbers
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("Five Random Numbers (1-100):");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(random.Next(1, 101) + " ");
            }
            Console.WriteLine();
            int diceRoll = random.Next(1, 7);
            string coinFlip = random.Next(0, 2) == 0 ? "Heads" : "Tails";
            Console.WriteLine($"Dice Roll: {diceRoll}");
            Console.WriteLine($"Coin Flip: {coinFlip}");
        }
    }
}
