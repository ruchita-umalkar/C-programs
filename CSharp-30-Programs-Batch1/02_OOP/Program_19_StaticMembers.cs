// ============================================
// Program #19 — StaticMembers
// Category  : 02_OOP
// Difficulty: Intermediate
// Description: Track object count using a static member
// ============================================

using System;

namespace CSharp30Programs.OOP
{
    class Counter
    {
        public static int Count { get; private set; }

        public Counter()
        {
            Count++;
            Console.WriteLine($"Counter created. Total: {Count}");
        }
    }

    class Program_19_StaticMembers
    {
        static void Main(string[] args)
        {
            new Counter();
            new Counter();
            new Counter();

            Console.WriteLine($"Final count: {Counter.Count}");
        }
    }
}
