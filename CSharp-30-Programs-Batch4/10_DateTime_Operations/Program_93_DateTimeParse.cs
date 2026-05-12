// ============================================
// Program #93 — DateTimeParse
// Category  : 10_DateTime_Operations
// Difficulty: Basic
// Description: Parse date from string and display in formatted styles
// ============================================

using System;

namespace CSharp30Programs.DateTimeOperations
{
    class Program_93_DateTimeParse
    {
        static void Main(string[] args)
        {
            string inputDate = "2026-12-25";
            DateTime parsedDate = DateTime.Parse(inputDate);
            Console.WriteLine($"Input String: {inputDate}");
            Console.WriteLine($"Parsed Date: {parsedDate}");
            Console.WriteLine($"Formatted Date: {parsedDate:dddd, dd MMMM yyyy}");
        }
    }
}
