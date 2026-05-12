// ============================================
// Program #97 — CountdownTimer
// Category  : 10_DateTime_Operations
// Difficulty: Intermediate
// Description: Calculate days remaining until a future date
// ============================================

using System;

namespace CSharp30Programs.DateTimeOperations
{
    class Program_97_CountdownTimer
    {
        static void Main(string[] args)
        {
            DateTime futureDate = new DateTime(2027, 1, 1);
            DateTime today = DateTime.Today;
            TimeSpan remaining = futureDate - today;
            Console.WriteLine($"Today: {today:dd/MM/yyyy}");
            Console.WriteLine($"Target Date: {futureDate:dd/MM/yyyy}");
            if (remaining.TotalDays >= 0)
            {
                Console.WriteLine($"Days Remaining: {remaining.Days}");
            }
            else
            {
                Console.WriteLine("The target date has already passed.");
            }
        }
    }
}
