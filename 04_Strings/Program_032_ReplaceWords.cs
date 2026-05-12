// ============================================
// Program #032 — ReplaceWords
// Category  : 04_Strings
// Difficulty: Basic
// Description: Replace a word in a sentence using string.Replace
// ============================================

using System;

namespace CSharp30Programs.Strings
{
    class Program_032_ReplaceWords
    {
        static void Main(string[] args)
        {
            string sentence = "I like tea in the morning.";
            string updated = sentence.Replace("tea", "coffee");

            Console.WriteLine($"Original: {sentence}");
            Console.WriteLine($"Updated : {updated}");
        }
    }
}
