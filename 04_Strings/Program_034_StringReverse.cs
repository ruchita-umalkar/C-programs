// ============================================
// Program #034 — StringReverse
// Category  : 04_Strings
// Difficulty: Basic
// Description: Reverse each word in a sentence individually
// ============================================

using System;

namespace CSharp30Programs.Strings
{
    class Program_034_StringReverse
    {
        static void Main(string[] args)
        {
            string sentence = "Reverse each word";
            string[] words = sentence.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                char[] chars = words[i].ToCharArray();
                Array.Reverse(chars);
                words[i] = new string(chars);
            }

            Console.WriteLine($"Original: {sentence}");
            Console.WriteLine($"Result  : {string.Join(" ", words)}");
        }
    }
}
