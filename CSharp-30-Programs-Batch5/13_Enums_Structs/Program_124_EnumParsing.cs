// ============================================
// Program #124 — EnumParsing
// Category  : 13_Enums_Structs
// Difficulty: Intermediate
// Description: Parse enum values from strings using Parse and TryParse
// ============================================

using System;

namespace CSharp30Programs.EnumsStructs
{
    class Program_124_EnumParsing
    {
        static void Main(string[] args)
        {
            string input1 = "Friday";
            DayOfWeek parsed = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), input1);
            Console.WriteLine($"Parsed with Enum.Parse: {parsed}");

            string input2 = "sunday";
            bool ok = Enum.TryParse(input2, true, out DayOfWeek parsed2);
            Console.WriteLine(ok
                ? $"Parsed with Enum.TryParse: {parsed2}"
                : "TryParse failed");
        }


    }
}
