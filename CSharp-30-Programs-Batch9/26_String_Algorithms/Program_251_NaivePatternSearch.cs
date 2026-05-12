// ============================================
// Program #251 — NaivePatternSearch
// Category  : 26_String_Algorithms
// Difficulty: Intermediate
// Description: Perform naive pattern search and print matching positions.
// ============================================

using System;

namespace CSharp30Programs.StringAlgorithms
{
    class Program_251_NaivePatternSearch
    {
        static void Main(string[] args)
        {
            string text = "AABAACAADAABAABA";
            string pattern = "AABA";

            Console.WriteLine($"Text: {text}");
            Console.WriteLine($"Pattern: {pattern}");
            Console.WriteLine("Matches at indices:");

            for (int i = 0; i <= text.Length - pattern.Length; i++)
            {
                int j;
                for (j = 0; j < pattern.Length; j++)
                {
                    if (text[i + j] != pattern[j]) break;
                }

                if (j == pattern.Length)
                    Console.WriteLine($"- {i}");
            }
        }
    }
}
