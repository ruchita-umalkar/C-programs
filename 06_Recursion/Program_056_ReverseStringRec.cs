// ============================================
// Program #056 — ReverseStringRec
// Category  : 06_Recursion
// Difficulty: Intermediate
// Description: Reverse a string using recursion
// ============================================

using System;

namespace CSharp30Programs.Recursion
{
    class Program_056_ReverseStringRec
    {
        static void Main(string[] args)
        {
            string text = "recursion";
            char[] chars = text.ToCharArray();
            Reverse(chars, 0, chars.Length - 1);

            Console.WriteLine($"Original: {text}");
            Console.WriteLine($"Reversed: {new string(chars)}");
        }

        static void Reverse(char[] chars, int left, int right)
        {
            if (left >= right)
            {
                return;
            }

            char temp = chars[left];
            chars[left] = chars[right];
            chars[right] = temp;

            Reverse(chars, left + 1, right - 1);
        }
    }
}
