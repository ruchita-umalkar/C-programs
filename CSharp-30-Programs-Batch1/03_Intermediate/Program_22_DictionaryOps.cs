// ============================================
// Program #22 — DictionaryOps
// Category  : 03_Intermediate
// Difficulty: Intermediate
// Description: Count word frequency in a sentence using a dictionary
// ============================================

using System;
using System.Collections.Generic;

namespace CSharp30Programs.Intermediate
{
    class Program_22_DictionaryOps
    {
        static void Main(string[] args)
        {
            string sentence = "this is a simple simple sentence";
            string[] words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> frequencies = new Dictionary<string, int>();
            foreach (string word in words)
            {
                string key = word.ToLower();
                if (!frequencies.ContainsKey(key))
                {
                    frequencies[key] = 0;
                }

                frequencies[key]++;
            }

            Console.WriteLine($"Sentence: {sentence}");
            Console.WriteLine("Word frequencies:");
            foreach (KeyValuePair<string, int> pair in frequencies)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }
    }
}
