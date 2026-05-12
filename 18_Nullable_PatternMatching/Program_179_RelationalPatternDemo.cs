// ============================================
// Program #179 — RelationalPatternDemo
// Category  : 18_Nullable_PatternMatching
// Difficulty: Intermediate
// Description: Uses relational patterns to classify temperature
// ============================================

using System;

namespace CSharp30Programs.NullablePatternMatching
{
    class Program_179_RelationalPatternDemo
    {
        static void Main(string[] args)
        {
            int temperature = 32;
            string status = temperature switch
            {
                < 0 => "Freezing",
                >= 0 and < 20 => "Cold",
                >= 20 and < 30 => "Warm",
                _ => "Hot"
            };

            Console.WriteLine($"Temperature status: {status}");
        }
    }
}
