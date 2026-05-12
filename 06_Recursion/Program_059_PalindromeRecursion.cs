// ============================================
// Program #059 — PalindromeRecursion
// Category  : 06_Recursion
// Difficulty: Intermediate
// Description: Check palindrome using recursion
// ============================================

using System;

namespace CSharp30Programs.Recursion
{
    class Program_059_PalindromeRecursion
    {
        static void Main(string[] args)
        {
            string text = "level";
            bool isPalindrome = IsPalindrome(text, 0, text.Length - 1);

            Console.WriteLine($"Text: {text}");
            Console.WriteLine($"Is palindrome: {isPalindrome}");
        }

        static bool IsPalindrome(string text, int left, int right)
        {
            if (left >= right)
            {
                return true;
            }

            if (text[left] != text[right])
            {
                return false;
            }

            return IsPalindrome(text, left + 1, right - 1);
        }
    }
}
