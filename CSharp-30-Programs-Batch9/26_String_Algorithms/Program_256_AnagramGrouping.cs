// ============================================
// Program #256 — AnagramGrouping
// Category  : 26_String_Algorithms
// Difficulty: Intermediate
// Description: Group anagrams from a list of words using sorted-key mapping.
// ============================================

using System;
using System.Collections.Generic;

namespace CSharp30Programs.StringAlgorithms
{
    class Program_256_AnagramGrouping
    {
        static void Main(string[] args)
        {
            string[] words = { "eat", "tea", "tan", "ate", "nat", "bat" };
            Dictionary<string, List<string>> groups = new Dictionary<string, List<string>>();

            foreach (var word in words)
            {
                char[] chars = word.ToCharArray();
                Array.Sort(chars);
                string key = new string(chars);

                if (!groups.ContainsKey(key)) groups[key] = new List<string>();
                groups[key].Add(word);
            }

            Console.WriteLine("Anagram groups:");
            foreach (var kv in groups)
            {
                Console.WriteLine($"- {string.Join(", ", kv.Value)}");
            }
        }
    }
}
