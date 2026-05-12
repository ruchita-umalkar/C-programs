// ============================================
// Program #141 — DelegateBasics
// Category  : 15_Delegates_Events
// Difficulty: Basic
// Description: Declare and invoke a simple delegate
// ============================================

using System;

namespace CSharp30Programs.DelegatesEvents
{
    class Program_141_DelegateBasics
    {
        static void Main(string[] args)
        {
            Calculator operation = Add;
            int result = operation(8, 4);
            Console.WriteLine($"Result: {result}");
        }


        delegate int Calculator(int a, int b);

        static int Add(int x, int y)
        {
            return x + y;
        }
    }
}
