// ============================================
// Program #180 — ListPattern
// Category  : 18_Nullable_PatternMatching
// Difficulty: Intermediate
// Description: Demonstrates list pattern matching on integer arrays
// ============================================

using System;

namespace CSharp30Programs.NullablePatternMatching
{
    class Program_180_ListPattern
    {
        static void Main(string[] args)
        {
            int[] values = { 1, 2, 3, 4 };

            string result = values switch
            {
                [1, 2, ..] => "Starts with 1, 2",
                [.., 4] => "Ends with 4",
                _ => "No pattern matched"
            };

            Console.WriteLine(result);
        }
    }
}
