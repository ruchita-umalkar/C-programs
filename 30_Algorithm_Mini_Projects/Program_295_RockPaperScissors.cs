// ============================================
// Program #295 — RockPaperScissors
// Category  : 30_Algorithm_Mini_Projects
// Difficulty: [Intermediate]
// Description: Rock Paper Scissors game against computer with score tracking.
// ============================================

using System;

namespace CSharp30Programs.AlgorithmMiniProjects
{
    class Program_295_RockPaperScissors
    {
        static void Main(string[] args)
        {
            string[] moves = { "rock", "paper", "scissors" };
            int user = 0, cpu = 0;
            var r = new Random();
            while (true)
            {
                Console.Write("Enter rock/paper/scissors or exit: ");
                string input = (Console.ReadLine() ?? "").Trim().ToLower();
                if (input == "exit") break;
                if (Array.IndexOf(moves, input) < 0) { Console.WriteLine("Invalid move."); continue; }
                string comp = moves[r.Next(3)];
                Console.WriteLine($"Computer: {comp}");
                if (input == comp) Console.WriteLine("Draw.");
                else if ((input == "rock" && comp == "scissors") || (input == "paper" && comp == "rock") || (input == "scissors" && comp == "paper"))
                { user++; Console.WriteLine("You win this round."); }
                else { cpu++; Console.WriteLine("Computer wins this round."); }
                Console.WriteLine($"Score -> You: {user} | Computer: {cpu}");
            }
            Console.WriteLine($"Final Score -> You: {user}, Computer: {cpu}");
        }
    }
}
