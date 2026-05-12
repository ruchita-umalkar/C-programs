// ============================================
// Program #100 — DateTimeComparison
// Category  : 10_DateTime_Operations
// Difficulty: Basic
// Description: Compare two dates for earlier, later, and equality
// ============================================

using System;

namespace CSharp30Programs.DateTimeOperations
{
    class Program_100_DateTimeComparison
    {
        static void Main(string[] args)
        {
            DateTime date1 = new DateTime(2026, 4, 8);
            DateTime date2 = new DateTime(2026, 6, 1);
            Console.WriteLine($"Date 1: {date1:dd/MM/yyyy}");
            Console.WriteLine($"Date 2: {date2:dd/MM/yyyy}");
            Console.WriteLine($"Are Equal: {date1 == date2}");
            Console.WriteLine($"Earlier Date: {(date1 < date2 ? date1 : date2):dd/MM/yyyy}");
            Console.WriteLine($"Later Date: {(date1 > date2 ? date1 : date2):dd/MM/yyyy}");
        }
    }
}
