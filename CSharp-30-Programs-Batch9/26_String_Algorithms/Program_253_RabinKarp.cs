// ============================================
// Program #253 — RabinKarp
// Category  : 26_String_Algorithms
// Difficulty: Intermediate
// Description: Search pattern using Rabin-Karp rolling hash algorithm.
// ============================================

using System;

namespace CSharp30Programs.StringAlgorithms
{
    class Program_253_RabinKarp
    {
        static void Main(string[] args)
        {
            string text = "GEEKS FOR GEEKS";
            string pattern = "GEEK";
            int d = 256;
            int q = 101;
            int m = pattern.Length;
            int n = text.Length;
            int h = 1;

            for (int i = 0; i < m - 1; i++) h = (h * d) % q;

            int p = 0, t = 0;
            for (int i = 0; i < m; i++)
            {
                p = (d * p + pattern[i]) % q;
                t = (d * t + text[i]) % q;
            }

            Console.WriteLine("Pattern found at indices:");
            for (int i = 0; i <= n - m; i++)
            {
                if (p == t)
                {
                    int j;
                    for (j = 0; j < m; j++)
                    {
                        if (text[i + j] != pattern[j]) break;
                    }
                    if (j == m) Console.WriteLine($"- {i}");
                }

                if (i < n - m)
                {
                    t = (d * (t - text[i] * h) + text[i + m]) % q;
                    if (t < 0) t += q;
                }
            }
        }
    }
}
