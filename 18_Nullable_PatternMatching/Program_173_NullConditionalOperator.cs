// ============================================
// Program #173 — NullConditionalOperator
// Category  : 18_Nullable_PatternMatching
// Difficulty: Intermediate
// Description: Uses null-conditional operator to safely access members
// ============================================

using System;

namespace CSharp30Programs.NullablePatternMatching
{
    class Program_173_NullConditionalOperator
    {
        static void Main(string[] args)
        {
            string? text = null;
            int? length = text?.Length;
            Console.WriteLine($"Length: {(length?.ToString() ?? "null")}");
        }
    }
}
