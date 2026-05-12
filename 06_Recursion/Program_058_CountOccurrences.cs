// ============================================
// Program #058 — CountOccurrences
// Category  : 06_Recursion
// Difficulty: Intermediate
// Description: Count occurrences of a char in string recursively
// ============================================

using System;

namespace CSharp30Programs.Recursion
{
    class Program_058_CountOccurrences
    {
        static void Main(string[] args)
        {
            string text = "recursion rocks";
            char target = 'r';

            Console.WriteLine($"Text: {text}");
            Console.WriteLine($"'{target}' occurs {Count(text, target, 0)} times.");
        }

        static int Count(string text, char target, int index)
        {
            if (index >= text.Length)
            {
                return 0;
            }

            int current = text[index] == target ? 1 : 0;
            return current + Count(text, target, index + 1);
        }
    }
}
