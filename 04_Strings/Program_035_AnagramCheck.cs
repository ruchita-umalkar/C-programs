// ============================================
// Program #035 — AnagramCheck
// Category  : 04_Strings
// Difficulty: Basic
// Description: Check if two strings are anagrams
// ============================================

using System;

namespace CSharp30Programs.Strings
{
    class Program_035_AnagramCheck
    {
        static void Main(string[] args)
        {
            string first = "listen";
            string second = "silent";

            char[] a = first.ToLower().ToCharArray();
            char[] b = second.ToLower().ToCharArray();
            Array.Sort(a);
            Array.Sort(b);

            bool isAnagram = new string(a) == new string(b);

            Console.WriteLine($"First : {first}");
            Console.WriteLine($"Second: {second}");
            Console.WriteLine($"Anagram: {isAnagram}");
        }
    }
}
