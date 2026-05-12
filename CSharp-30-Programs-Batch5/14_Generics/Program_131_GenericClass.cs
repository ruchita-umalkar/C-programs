// ============================================
// Program #131 — GenericClass
// Category  : 14_Generics
// Difficulty: Intermediate
// Description: Create and use a generic Pair class
// ============================================

using System;

namespace CSharp30Programs.Generics
{
    class Program_131_GenericClass
    {
        static void Main(string[] args)
        {
            Pair<string, int> student = new Pair<string, int>("Riya", 92);
            Console.WriteLine($"Name: {student.First}, Score: {student.Second}");
        }


        class Pair<TFirst, TSecond>
        {
            public TFirst First { get; }
            public TSecond Second { get; }

            public Pair(TFirst first, TSecond second)
            {
                First = first;
                Second = second;
            }
        }
    }
}
