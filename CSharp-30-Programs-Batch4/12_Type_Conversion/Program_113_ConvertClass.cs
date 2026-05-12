// ============================================
// Program #113 — ConvertClass
// Category  : 12_Type_Conversion
// Difficulty: Basic
// Description: Use Convert class methods for multiple type conversions
// ============================================

using System;

namespace CSharp30Programs.TypeConversion
{
    class Program_113_ConvertClass
    {
        static void Main(string[] args)
        {
            string numberText = "250";
            int intValue = Convert.ToInt32(numberText);
            double doubleValue = Convert.ToDouble("99.75");
            string textValue = Convert.ToString(12345);
            bool boolValue = Convert.ToBoolean(1);
            Console.WriteLine($"ToInt32(\"250\"): {intValue}");
            Console.WriteLine($"ToDouble(\"99.75\"): {doubleValue}");
            Console.WriteLine($"ToString(12345): {textValue}");
            Console.WriteLine($"ToBoolean(1): {boolValue}");
        }
    }
}
