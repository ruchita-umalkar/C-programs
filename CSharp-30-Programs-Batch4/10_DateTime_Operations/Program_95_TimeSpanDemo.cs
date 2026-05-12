// ============================================
// Program #95 — TimeSpanDemo
// Category  : 10_DateTime_Operations
// Difficulty: Basic
// Description: Calculate difference between two dates using TimeSpan
// ============================================

using System;

namespace CSharp30Programs.DateTimeOperations
{
    class Program_95_TimeSpanDemo
    {
        static void Main(string[] args)
        {
            DateTime startDate = new DateTime(2026, 1, 1);
            DateTime endDate = new DateTime(2026, 4, 8);
            TimeSpan difference = endDate - startDate;
            Console.WriteLine($"Start Date: {startDate:dd/MM/yyyy}");
            Console.WriteLine($"End Date: {endDate:dd/MM/yyyy}");
            Console.WriteLine($"Difference in Days: {difference.Days}");
            Console.WriteLine($"Difference in Total Hours: {difference.TotalHours}");
        }
    }
}
