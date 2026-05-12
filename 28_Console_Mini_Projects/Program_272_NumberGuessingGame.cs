// ============================================
// Program #272 — NumberGuessingGame
// Category  : 28_Console_Mini_Projects
// Difficulty: [Intermediate]
// Description: Number guessing game with hints, attempts, and replay.
// ============================================

using System;

namespace CSharp30Programs.ConsoleMiniProjects
{
    class Program_272_NumberGuessingGame
    {
        static void Main(string[] args)
        {
            var random = new Random();
            Console.WriteLine("Number Guessing Game");
            while (true)
            {
                int target = random.Next(1, 101);
                int attempts = 0;
                Console.WriteLine("I picked a number between 1 and 100.");
                while (true)
                {
                    Console.Write("Your guess: ");
                    if (!int.TryParse(Console.ReadLine(), out int guess))
                    {
                        Console.WriteLine("Enter a valid integer.");
                        continue;
                    }
                    attempts++;
                    if (guess == target)
                    {
                        Console.WriteLine($"Correct! Attempts: {attempts}");
                        break;
                    }
                    Console.WriteLine(guess < target ? "Too low." : "Too high.");
                }

                Console.Write("Play again? (y/n): ");
                if (!string.Equals((Console.ReadLine() ?? "").Trim(), "y", StringComparison.OrdinalIgnoreCase))
                    break;
            }
            Console.WriteLine("Game over.");
        }
    }
}
