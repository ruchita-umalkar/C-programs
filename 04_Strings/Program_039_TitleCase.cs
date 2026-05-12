// ============================================
// Program #039 — TitleCase
// Category  : 04_Strings
// Difficulty: Basic
// Description: Convert string to Title Case
// ============================================

using System;

namespace CSharp30Programs.Strings
{
    class Program_039_TitleCase
    {
        static void Main(string[] args)
        {
            string text = "welcome to c sharp programming";
            string titleCase = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(text);

            Console.WriteLine($"Original: {text}");
            Console.WriteLine($"Title   : {titleCase}");
        }
    }
}
