// ============================================
// Program #031 — CountVowels
// Category  : 04_Strings
// Difficulty: Basic
// Description: Count vowels and consonants in a string
// ============================================

using System;

namespace CSharp30Programs.Strings
{
    class Program_031_CountVowels
    {
        static void Main(string[] args)
        {
            string text = "Hello CSharp World";
            int vowels = 0;
            int consonants = 0;

            foreach (char ch in text.ToLower())
            {
                if (char.IsLetter(ch))
                {
                    if ("aeiou".IndexOf(ch) >= 0)
                    {
                        vowels++;
                    }
                    else
                    {
                        consonants++;
                    }
                }
            }

            Console.WriteLine($"Input: {text}");
            Console.WriteLine($"Vowels: {vowels}");
            Console.WriteLine($"Consonants: {consonants}");
        }
    }
}
