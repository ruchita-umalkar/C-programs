// ============================================
// Program #9 — ReverseString
// Category  : 01_Basics
// Difficulty: Basic
// Description: Reverse a string and display both versions
// ============================================

using System;

namespace CSharp30Programs.Basics
{
    class Program_9_ReverseString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine() ?? string.Empty;

            char[] chars = input.ToCharArray();
            Array.Reverse(chars);
            string reversed = new string(chars);

            Console.WriteLine($"Original: {input} | Reversed: {reversed}");
        }
    }
}
