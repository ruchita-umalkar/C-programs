// ============================================
// Program #10 — PalindromeCheck
// Category  : 01_Basics
// Difficulty: Basic
// Description: Check if a string is a palindrome ignoring case and spaces
// ============================================

using System;
using System.Text;

namespace CSharp30Programs.Basics
{
    class Program_10_PalindromeCheck
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine() ?? string.Empty;

            StringBuilder builder = new StringBuilder();
            foreach (char ch in input)
            {
                if (!char.IsWhiteSpace(ch))
                {
                    builder.Append(char.ToLower(ch));
                }
            }
            string cleaned = builder.ToString();

            char[] chars = cleaned.ToCharArray();
            Array.Reverse(chars);
            string reversed = new string(chars);

            bool isPalindrome = cleaned == reversed;
            Console.WriteLine(isPalindrome
                ? "The string is a palindrome."
                : "The string is not a palindrome.");
        }
    }
}
