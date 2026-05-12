// ============================================
// Program #171 — NullableValueTypes
// Category  : 18_Nullable_PatternMatching
// Difficulty: Intermediate
// Description: Shows declaration and usage of nullable value types
// ============================================

using System;

namespace CSharp30Programs.NullablePatternMatching
{
    class Program_171_NullableValueTypes
    {
        static void Main(string[] args)
        {
            int? age = null;
            Console.WriteLine($"Has value: {age.HasValue}");

            age = 28;
            Console.WriteLine($"Age: {age}");
        }
    }
}
