// ============================================
// Program #111 — ImplicitCasting
// Category  : 12_Type_Conversion
// Difficulty: Basic
// Description: Demonstrate implicit casting from int to long and float to double
// ============================================

using System;

namespace CSharp30Programs.TypeConversion
{
    class Program_111_ImplicitCasting
    {
        static void Main(string[] args)
        {
            int intValue = 100;
            long longValue = intValue;
            float floatValue = 12.34f;
            double doubleValue = floatValue;
            Console.WriteLine($"int value: {intValue}, long value: {longValue}");
            Console.WriteLine($"float value: {floatValue}, double value: {doubleValue}");
        }
    }
}
