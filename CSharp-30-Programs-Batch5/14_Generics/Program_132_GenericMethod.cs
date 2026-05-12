// ============================================
// Program #132 — GenericMethod
// Category  : 14_Generics
// Difficulty: Intermediate
// Description: Create a generic method to print any type of value
// ============================================

using System;

namespace CSharp30Programs.Generics
{
    class Program_132_GenericMethod
    {
        static void Main(string[] args)
        {
            PrintValue(42);
            PrintValue(3.14);
            PrintValue("Hello Generics");
        }


        static void PrintValue<T>(T value)
        {
            Console.WriteLine($"Type={typeof(T).Name}, Value={value}");
        }
    }
}
