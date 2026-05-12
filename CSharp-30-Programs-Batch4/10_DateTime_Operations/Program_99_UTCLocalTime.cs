// ============================================
// Program #99 — UTCLocalTime
// Category  : 10_DateTime_Operations
// Difficulty: Intermediate
// Description: Convert UTC time to local and display both
// ============================================

using System;

namespace CSharp30Programs.DateTimeOperations
{
    class Program_99_UTCLocalTime
    {
        static void Main(string[] args)
        {
            DateTime utcNow = DateTime.UtcNow;
            DateTime localNow = utcNow.ToLocalTime();
            Console.WriteLine($"UTC Time: {utcNow:yyyy-MM-dd HH:mm:ss} UTC");
            Console.WriteLine($"Local Time: {localNow:yyyy-MM-dd HH:mm:ss}");
        }
    }
}
