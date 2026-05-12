// ============================================
// Program #98 — DayOfWeekFinder
// Category  : 10_DateTime_Operations
// Difficulty: Basic
// Description: Find day of week for a given date
// ============================================

using System;

namespace CSharp30Programs.DateTimeOperations
{
    class Program_98_DayOfWeekFinder
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime(2026, 8, 15);
            Console.WriteLine($"Date: {date:dd/MM/yyyy}");
            Console.WriteLine($"Day of Week: {date.DayOfWeek}");
        }
    }
}
