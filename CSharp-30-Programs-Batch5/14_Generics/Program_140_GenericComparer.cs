// ============================================
// Program #140 — GenericComparer
// Category  : 14_Generics
// Difficulty: Intermediate
// Description: Create a generic comparer to find maximum value
// ============================================

using System;

namespace CSharp30Programs.Generics
{
    class Program_140_GenericComparer
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Max int: {GetMax(12, 5)}");
            Console.WriteLine($"Max string: {GetMax("Orange", "Apple")}");
        }


        static T GetMax<T>(T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b) >= 0 ? a : b;
        }
    }
}
