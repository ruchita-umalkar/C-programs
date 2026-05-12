// ============================================
// Program #26 — DateTimeDifference
// Category  : 03_Intermediate
// Difficulty: Intermediate
// Description: Calculate the day difference between two dates
// ============================================

using System;

namespace CSharp30Programs.Intermediate
{
    class Program_26_DateTimeDifference
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first date (yyyy-MM-dd):");
            string firstInput = Console.ReadLine();
            DateTime firstDate;
            if (!DateTime.TryParse(firstInput, out firstDate))
            {
                firstDate = DateTime.Today;
            }

            Console.WriteLine("Enter the second date (yyyy-MM-dd):");
            string secondInput = Console.ReadLine();
            DateTime secondDate;
            if (!DateTime.TryParse(secondInput, out secondDate))
            {
                secondDate = DateTime.Today.AddDays(7);
            }

            TimeSpan difference = secondDate - firstDate;

            Console.WriteLine($"First date: {firstDate:d}");
            Console.WriteLine($"Second date: {secondDate:d}");
            Console.WriteLine($"Difference in days: {Math.Abs(difference.TotalDays)}");
        }
    }
}
