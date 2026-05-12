// ============================================
// Program #252 — KMPAlgorithm
// Category  : 26_String_Algorithms
// Difficulty: Intermediate
// Description: Search pattern in text using KMP and print LPS table.
// ============================================

using System;

namespace CSharp30Programs.StringAlgorithms
{
    class Program_252_KMPAlgorithm
    {
        static int[] BuildLps(string pattern)
        {
            int[] lps = new int[pattern.Length];
            int len = 0;
            int i = 1;

            while (i < pattern.Length)
            {
                if (pattern[i] == pattern[len])
                {
                    len++;
                    lps[i] = len;
                    i++;
                }
                else if (len != 0)
                {
                    len = lps[len - 1];
                }
                else
                {
                    lps[i] = 0;
                    i++;
                }
            }

            return lps;
        }

        static void Main(string[] args)
        {
            string text = "ABABDABACDABABCABAB";
            string pattern = "ABABCABAB";
            int[] lps = BuildLps(pattern);

            Console.WriteLine("LPS table:");
            for (int i = 0; i < lps.Length; i++)
                Console.WriteLine($"{pattern[i]} -> {lps[i]}");

            int ti = 0, pi = 0;
            Console.WriteLine("Pattern found at indices:");
            while (ti < text.Length)
            {
                if (text[ti] == pattern[pi])
                {
                    ti++;
                    pi++;
                }

                if (pi == pattern.Length)
                {
                    Console.WriteLine($"- {ti - pi}");
                    pi = lps[pi - 1];
                }
                else if (ti < text.Length && text[ti] != pattern[pi])
                {
                    if (pi != 0)
                        pi = lps[pi - 1];
                    else
                        ti++;
                }
            }
        }
    }
}
