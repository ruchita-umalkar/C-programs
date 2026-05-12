// ============================================
// Program #258 — LongestCommonPrefix
// Category  : 26_String_Algorithms
// Difficulty: Intermediate
// Description: Find the longest common prefix among an array of strings.
// ============================================

using System;

namespace CSharp30Programs.StringAlgorithms
{
    class Program_258_LongestCommonPrefix
    {
        static void Main(string[] args)
        {
            string[] arr = { "flower", "flow", "flight" };
            string prefix = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                while (!arr[i].StartsWith(prefix))
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);
                    if (prefix.Length == 0) break;
                }
            }

            Console.WriteLine($"Longest common prefix = '{prefix}'");
        }
    }
}
