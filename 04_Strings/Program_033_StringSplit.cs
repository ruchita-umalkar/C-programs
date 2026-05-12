// ============================================
// Program #033 — StringSplit
// Category  : 04_Strings
// Difficulty: Basic
// Description: Split a sentence into words and print each
// ============================================

using System;

namespace CSharp30Programs.Strings
{
    class Program_033_StringSplit
    {
        static void Main(string[] args)
        {
            string sentence = "CSharp is fun to learn";
            string[] words = sentence.Split(' ');

            Console.WriteLine("Words in sentence:");
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
