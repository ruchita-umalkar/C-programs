// ============================================
// Program #121 — EnumBasics
// Category  : 13_Enums_Structs
// Difficulty: Basic
// Description: Declare enum, assign and print enum values
// ============================================

using System;

namespace CSharp30Programs.EnumsStructs
{
    class Program_121_EnumBasics
    {
        static void Main(string[] args)
        {
            Priority current = Priority.High;
            Console.WriteLine($"Selected priority: {current}");
            Console.WriteLine($"Numeric value: {(int)current}");
        }


        enum Priority { Low, Medium, High }
    }
}
