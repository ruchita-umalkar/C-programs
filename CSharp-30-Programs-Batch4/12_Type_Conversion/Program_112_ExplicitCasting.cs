// ============================================
// Program #112 — ExplicitCasting
// Category  : 12_Type_Conversion
// Difficulty: Basic
// Description: Demonstrate explicit casting with possible data loss
// ============================================

using System;

namespace CSharp30Programs.TypeConversion
{
    class Program_112_ExplicitCasting
    {
        static void Main(string[] args)
        {
            double doubleValue = 123.987;
            int intFromDouble = (int)doubleValue;
            long longValue = 3000000000;
            int intFromLong = (int)longValue;
            Console.WriteLine($"double: {doubleValue} -> int: {intFromDouble}");
            Console.WriteLine($"long: {longValue} -> int (data loss): {intFromLong}");
        }
    }
}
