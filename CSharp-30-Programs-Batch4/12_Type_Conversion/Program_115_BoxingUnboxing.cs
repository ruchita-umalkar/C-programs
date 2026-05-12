// ============================================
// Program #115 — BoxingUnboxing
// Category  : 12_Type_Conversion
// Difficulty: Intermediate
// Description: Demonstrate boxing and unboxing of integer values
// ============================================

using System;

namespace CSharp30Programs.TypeConversion
{
    class Program_115_BoxingUnboxing
    {
        static void Main(string[] args)
        {
            int originalValue = 500;
            object boxedValue = originalValue;
            int unboxedValue = (int)boxedValue;
            Console.WriteLine($"Original int: {originalValue}");
            Console.WriteLine($"Boxed object: {boxedValue}");
            Console.WriteLine($"Unboxed int: {unboxedValue}");
        }
    }
}
