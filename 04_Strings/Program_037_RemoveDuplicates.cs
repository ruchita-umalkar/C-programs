// ============================================
// Program #037 — RemoveDuplicates
// Category  : 04_Strings
// Difficulty: Basic
// Description: Remove duplicate characters from a string
// ============================================

using System;

namespace CSharp30Programs.Strings
{
    class Program_037_RemoveDuplicates
    {
        static void Main(string[] args)
        {
            string text = "programming";
            var seen = new System.Collections.Generic.HashSet<char>();
            var result = new System.Text.StringBuilder();

            foreach (char ch in text)
            {
                if (seen.Add(ch))
                {
                    result.Append(ch);
                }
            }

            Console.WriteLine($"Original: {text}");
            Console.WriteLine($"Unique  : {result}");
        }
    }
}
