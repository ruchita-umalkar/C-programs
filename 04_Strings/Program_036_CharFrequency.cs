// ============================================
// Program #036 — CharFrequency
// Category  : 04_Strings
// Difficulty: Basic
// Description: Count frequency of each character in a string
// ============================================

using System;

namespace CSharp30Programs.Strings
{
    class Program_036_CharFrequency
    {
        static void Main(string[] args)
        {
            string text = "banana";
            var frequencies = new System.Collections.Generic.Dictionary<char, int>();

            foreach (char ch in text)
            {
                if (frequencies.ContainsKey(ch))
                {
                    frequencies[ch]++;
                }
                else
                {
                    frequencies[ch] = 1;
                }
            }

            Console.WriteLine($"Input: {text}");
            foreach (var pair in frequencies)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }
    }
}
