// ============================================
// Program #118 — SafeCastingPattern
// Category  : 12_Type_Conversion
// Difficulty: Intermediate
// Description: Use pattern matching for safe casting scenarios
// ============================================

using System;

namespace CSharp30Programs.TypeConversion
{
    class Program_118_SafeCastingPattern
    {
        static void Main(string[] args)
        {
            object[] items = { 100, "hello", 45.6, true };
            foreach (object item in items)
            {
                switch (item)
                {
                    case int i:
                        Console.WriteLine($"Integer detected: {i}");
                        break;
                    case string s:
                        Console.WriteLine($"String detected: {s.ToUpper()}");
                        break;
                    case double d:
                        Console.WriteLine($"Double detected: {d:F2}");
                        break;
                    default:
                        Console.WriteLine($"Other type detected: {item}");
                        break;
                }
            }
        }
    }
}
