// ============================================
// Program #257 — ZAlgorithm
// Category  : 26_String_Algorithms
// Difficulty: Intermediate
// Description: Perform pattern matching using Z algorithm in linear time.
// ============================================

using System;

namespace CSharp30Programs.StringAlgorithms
{
    class Program_257_ZAlgorithm
    {
        static int[] BuildZ(string s)
        {
            int n = s.Length;
            int[] z = new int[n];
            int l = 0, r = 0;

            for (int i = 1; i < n; i++)
            {
                if (i <= r)
                    z[i] = Math.Min(r - i + 1, z[i - l]);

                while (i + z[i] < n && s[z[i]] == s[i + z[i]])
                    z[i]++;

                if (i + z[i] - 1 > r)
                {
                    l = i;
                    r = i + z[i] - 1;
                }
            }
            return z;
        }

        static void Main(string[] args)
        {
            string text = "aabxaabxcaabxaabxay";
            string pattern = "aabx";
            string combined = pattern + "$" + text;
            int[] z = BuildZ(combined);

            Console.WriteLine("Pattern found at indices:");
            for (int i = 0; i < z.Length; i++)
            {
                if (z[i] == pattern.Length)
                    Console.WriteLine($"- {i - pattern.Length - 1}");
            }
        }
    }
}
