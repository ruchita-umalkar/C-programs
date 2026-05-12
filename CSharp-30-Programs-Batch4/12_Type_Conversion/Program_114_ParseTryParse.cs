// ============================================
// Program #114 — ParseTryParse
// Category  : 12_Type_Conversion
// Difficulty: Basic
// Description: Compare int.Parse with int.TryParse for safe conversion
// ============================================

using System;

namespace CSharp30Programs.TypeConversion
{
    class Program_114_ParseTryParse
    {
        static void Main(string[] args)
        {
            string validInput = "456";
            string invalidInput = "45A";
            int parsedValue = int.Parse(validInput);
            Console.WriteLine($"int.Parse(\"{validInput}\"): {parsedValue}");
            if (int.TryParse(invalidInput, out int safeValue))
            {
                Console.WriteLine($"int.TryParse succeeded: {safeValue}");
            }
            else
            {
                Console.WriteLine($"int.TryParse failed for input: {invalidInput}");
            }
        }
    }
}
