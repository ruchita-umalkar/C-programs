// ============================================
// Program #116 — AsIsKeyword
// Category  : 12_Type_Conversion
// Difficulty: Intermediate
// Description: Use is and as keywords for safe type checks and casts
// ============================================

using System;

namespace CSharp30Programs.TypeConversion
{
    class Program_116_AsIsKeyword
    {
        static void Main(string[] args)
        {
            object message = "CSharp Type Conversion";
            if (message is string text)
            {
                Console.WriteLine($"Using is: Length = {text.Length}");
            }
            object number = 42;
            string asString = number as string;
            Console.WriteLine(asString == null
                ? "Using as: Conversion failed safely (null returned)."
                : $"Using as: {asString}");
        }
    }
}
