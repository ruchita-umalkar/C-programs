// ============================================
// Program #94 — DateFormatting
// Category  : 10_DateTime_Operations
// Difficulty: Basic
// Description: Format dates using standard and custom patterns
// ============================================

using System;

namespace CSharp30Programs.DateTimeOperations
{
    class Program_94_DateFormatting
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime(2026, 11, 5, 16, 30, 45);
            Console.WriteLine($"Original: {date}");
            Console.WriteLine($"dd/MM/yyyy: {date:dd/MM/yyyy}");
            Console.WriteLine($"MMM dd yyyy: {date:MMM dd yyyy}");
            Console.WriteLine($"Custom (dddd, hh:mm tt): {date:dddd, hh:mm tt}");
        }
    }
}
