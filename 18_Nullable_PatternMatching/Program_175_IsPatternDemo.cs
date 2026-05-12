// ============================================
// Program #175 — IsPatternDemo
// Category  : 18_Nullable_PatternMatching
// Difficulty: Intermediate
// Description: Uses is pattern matching to check and cast type
// ============================================

using System;

namespace CSharp30Programs.NullablePatternMatching
{
    class Program_175_IsPatternDemo
    {
        static void Main(string[] args)
        {
            object value = 123;

            if (value is int number)
            {
                Console.WriteLine($"Integer value: {number}");
            }
        }
    }
}
