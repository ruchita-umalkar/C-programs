// ============================================
// Program #143 — ActionFuncPredicate
// Category  : 15_Delegates_Events
// Difficulty: Intermediate
// Description: Demonstrate Action, Func and Predicate delegates
// ============================================

using System;

namespace CSharp30Programs.DelegatesEvents
{
    class Program_143_ActionFuncPredicate
    {
        static void Main(string[] args)
        {
            Action<string> greet = name => Console.WriteLine($"Hello, {name}!");
            Func<int, int, int> multiply = (x, y) => x * y;
            Predicate<int> isEven = n => n % 2 == 0;

            greet("Neha");
            Console.WriteLine($"Multiply: {multiply(6, 7)}");
            Console.WriteLine($"Is 14 even? {isEven(14)}");
        }


    }
}
