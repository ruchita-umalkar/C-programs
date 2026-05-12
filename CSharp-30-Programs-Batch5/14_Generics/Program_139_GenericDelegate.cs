// ============================================
// Program #139 — GenericDelegate
// Category  : 14_Generics
// Difficulty: Intermediate
// Description: Use generic Func delegate for reusable operations
// ============================================

using System;

namespace CSharp30Programs.Generics
{
    class Program_139_GenericDelegate
    {
        static void Main(string[] args)
        {
            Func<int, int, int> add = (x, y) => x + y;
            Func<string, string, string> merge = (x, y) => x + y;

            Console.WriteLine($"Add: {add(4, 6)}");
            Console.WriteLine($"Merge: {merge("Gen", "erics")}");
        }


    }
}
