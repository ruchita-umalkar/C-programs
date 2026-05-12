// ============================================
// Program #172 — NullCoalescingOperator
// Category  : 18_Nullable_PatternMatching
// Difficulty: Intermediate
// Description: Demonstrates null-coalescing operator to provide defaults
// ============================================

using System;

namespace CSharp30Programs.NullablePatternMatching
{
    class Program_172_NullCoalescingOperator
    {
        static void Main(string[] args)
        {
            string? name = null;
            string displayName = name ?? "Guest";
            Console.WriteLine($"Hello, {displayName}");
        }
    }
}
