// ============================================
// Program #176 — SwitchExpressionDemo
// Category  : 18_Nullable_PatternMatching
// Difficulty: Intermediate
// Description: Uses switch expression with patterns for grading
// ============================================

using System;

namespace CSharp30Programs.NullablePatternMatching
{
    class Program_176_SwitchExpressionDemo
    {
        static void Main(string[] args)
        {
            int marks = 78;
            string grade = marks switch
            {
                >= 90 => "A",
                >= 75 => "B",
                >= 60 => "C",
                _ => "D"
            };

            Console.WriteLine($"Grade: {grade}");
        }
    }
}
