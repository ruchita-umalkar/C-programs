// ============================================
// Program #259 — WordReversal
// Category  : 26_String_Algorithms
// Difficulty: Intermediate
// Description: Reverse words in a sentence while preserving spaces.
// ============================================

using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp30Programs.StringAlgorithms
{
    class Program_259_WordReversal
    {
        static void Main(string[] args)
        {
            string input = "I  love   C# programming";
            List<string> words = new List<string>();
            StringBuilder current = new StringBuilder();

            foreach (char c in input)
            {
                if (c == ' ')
                {
                    if (current.Length > 0)
                    {
                        words.Add(current.ToString());
                        current.Clear();
                    }
                }
                else
                {
                    current.Append(c);
                }
            }
            if (current.Length > 0) words.Add(current.ToString());

            words.Reverse();
            int wi = 0;
            current.Clear();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                {
                    current.Append(' ');
                }
                else
                {
                    while (i < input.Length && input[i] != ' ') i++;
                    current.Append(words[wi++]);
                    i--;
                }
            }

            Console.WriteLine($"Original: '{input}'");
            Console.WriteLine($"Reversed: '{current}'");
        }
    }
}
