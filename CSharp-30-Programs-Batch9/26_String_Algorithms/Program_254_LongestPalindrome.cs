// ============================================
// Program #254 — LongestPalindrome
// Category  : 26_String_Algorithms
// Difficulty: Intermediate
// Description: Find the longest palindromic substring using center expansion.
// ============================================

using System;

namespace CSharp30Programs.StringAlgorithms
{
    class Program_254_LongestPalindrome
    {
        static (int start, int len) Expand(string s, int l, int r)
        {
            while (l >= 0 && r < s.Length && s[l] == s[r])
            {
                l--; r++;
            }
            return (l + 1, r - l - 1);
        }

        static void Main(string[] args)
        {
            string s = "babad";
            int bestStart = 0, bestLen = 1;

            for (int i = 0; i < s.Length; i++)
            {
                var odd = Expand(s, i, i);
                var even = Expand(s, i, i + 1);
                var cur = odd.len >= even.len ? odd : even;
                if (cur.len > bestLen)
                {
                    bestStart = cur.start;
                    bestLen = cur.len;
                }
            }

            Console.WriteLine($"Longest palindrome in '{s}' = '{s.Substring(bestStart, bestLen)}'");
        }
    }
}
