// ============================================
// Program #060 — TowerOfHanoi
// Category  : 06_Recursion
// Difficulty: Intermediate
// Description: Solve Tower of Hanoi for n disks recursively
// ============================================

using System;

namespace CSharp30Programs.Recursion
{
    class Program_060_TowerOfHanoi
    {
        static void Main(string[] args)
        {
            int disks = 3;
            Console.WriteLine($"Tower of Hanoi steps for {disks} disks:");
            Solve(disks, 'A', 'C', 'B');
        }

        static void Solve(int n, char from, char to, char aux)
        {
            if (n == 1)
            {
                Console.WriteLine($"Move disk 1 from {from} to {to}");
                return;
            }

            Solve(n - 1, from, aux, to);
            Console.WriteLine($"Move disk {n} from {from} to {to}");
            Solve(n - 1, aux, to, from);
        }
    }
}
