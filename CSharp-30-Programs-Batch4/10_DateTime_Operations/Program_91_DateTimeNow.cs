// ============================================
// Program #91 — DateTimeNow
// Category  : 10_DateTime_Operations
// Difficulty: Basic
// Description: Display current date, time, day, month, and year
// ============================================

using System;

namespace CSharp30Programs.DateTimeOperations
{
    class Program_91_DateTimeNow
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine($"Current Date and Time: {now}");
            Console.WriteLine($"Date: {now:dd/MM/yyyy}");
            Console.WriteLine($"Time: {now:HH:mm:ss}");
            Console.WriteLine($"Day: {now.Day}");
            Console.WriteLine($"Month: {now.Month}");
            Console.WriteLine($"Year: {now.Year}");
        }
    }
}
