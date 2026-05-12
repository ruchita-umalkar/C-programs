// ============================================
// Program #293 — SnakeAndLadder
// Category  : 30_Algorithm_Mini_Projects
// Difficulty: [Intermediate]
// Description: Snake and Ladder simulation with dice and board jumps.
// ============================================

using System;

namespace CSharp30Programs.AlgorithmMiniProjects
{
    class Program_293_SnakeAndLadder
    {
        static void Main(string[] args)
        {
            var jumps = new System.Collections.Generic.Dictionary<int, int>
            {
                [4]=14,[9]=31,[20]=38,[28]=84,[40]=59,[51]=67,[63]=81,[71]=91,
                [17]=7,[54]=34,[62]=19,[64]=60,[87]=24,[93]=73,[95]=75,[99]=78
            };
            int pos = 0;
            var rnd = new Random();
            Console.WriteLine("Snake and Ladder (single player)");
            while (pos < 100)
            {
                Console.Write("Press Enter to roll dice...");
                Console.ReadLine();
                int dice = rnd.Next(1, 7);
                int next = pos + dice;
                if (next <= 100) pos = next;
                if (jumps.ContainsKey(pos))
                {
                    int old = pos;
                    pos = jumps[pos];
                    Console.WriteLine(pos > old ? $"Ladder! {old} -> {pos}" : $"Snake! {old} -> {pos}");
                }
                Console.WriteLine($"Rolled {dice}, position: {pos}");
            }
            Console.WriteLine("You reached 100. You win!");
        }
    }
}
