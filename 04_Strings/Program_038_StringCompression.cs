// ============================================
// Program #038 — StringCompression
// Category  : 04_Strings
// Difficulty: Intermediate
// Description: Compress string e.g. "aaabbc" to "a3b2c1"
// ============================================

using System;

namespace CSharp30Programs.Strings
{
    class Program_038_StringCompression
    {
        static void Main(string[] args)
        {
            string text = "aaabbc";
            var compressed = new System.Text.StringBuilder();

            int count = 1;
            for (int i = 1; i <= text.Length; i++)
            {
                if (i < text.Length && text[i] == text[i - 1])
                {
                    count++;
                }
                else
                {
                    compressed.Append(text[i - 1]);
                    compressed.Append(count);
                    count = 1;
                }
            }

            Console.WriteLine($"Original  : {text}");
            Console.WriteLine($"Compressed: {compressed}");
        }
    }
}
