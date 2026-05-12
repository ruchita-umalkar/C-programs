// ============================================
// Program #174 — NullableReferenceCheck
// Category  : 18_Nullable_PatternMatching
// Difficulty: Intermediate
// Description: Checks nullable references before use
// ============================================

using System;

namespace CSharp30Programs.NullablePatternMatching
{
    class Program_174_NullableReferenceCheck
    {
        static void Main(string[] args)
        {
            string? input = "CSharp";

            if (input is not null)
            {
                Console.WriteLine($"Upper: {input.ToUpper()}");
            }
            else
            {
                Console.WriteLine("Input is null");
            }
        }
    }
}
