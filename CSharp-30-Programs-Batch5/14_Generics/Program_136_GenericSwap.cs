// ============================================
// Program #136 — GenericSwap
// Category  : 14_Generics
// Difficulty: Basic
// Description: Swap values using a generic method
// ============================================

using System;

namespace CSharp30Programs.Generics
{
    class Program_136_GenericSwap
    {
        static void Main(string[] args)
        {
            int a = 5, b = 9;
            Console.WriteLine($"Before swap: a={a}, b={b}");
            Swap(ref a, ref b);
            Console.WriteLine($"After swap : a={a}, b={b}");
        }


        static void Swap<T>(ref T left, ref T right)
        {
            T temp = left;
            left = right;
            right = temp;
        }
    }
}
