// ============================================
// Program #92 — DateArithmetic
// Category  : 10_DateTime_Operations
// Difficulty: Basic
// Description: Add and subtract days, months, and years from a date
// ============================================

using System;

namespace CSharp30Programs.DateTimeOperations
{
    class Program_92_DateArithmetic
    {
        static void Main(string[] args)
        {
            DateTime baseDate = new DateTime(2026, 4, 8);
            Console.WriteLine($"Base Date: {baseDate:dd/MM/yyyy}");
            Console.WriteLine($"+10 Days: {baseDate.AddDays(10):dd/MM/yyyy}");
            Console.WriteLine($"-5 Days: {baseDate.AddDays(-5):dd/MM/yyyy}");
            Console.WriteLine($"+2 Months: {baseDate.AddMonths(2):dd/MM/yyyy}");
            Console.WriteLine($"-1 Month: {baseDate.AddMonths(-1):dd/MM/yyyy}");
            Console.WriteLine($"+1 Year: {baseDate.AddYears(1):dd/MM/yyyy}");
            Console.WriteLine($"-3 Years: {baseDate.AddYears(-3):dd/MM/yyyy}");
        }
    }
}
