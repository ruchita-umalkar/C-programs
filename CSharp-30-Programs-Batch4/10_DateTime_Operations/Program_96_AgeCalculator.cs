// ============================================
// Program #96 — AgeCalculator
// Category  : 10_DateTime_Operations
// Difficulty: Basic
// Description: Calculate age from date of birth to current date
// ============================================

using System;

namespace CSharp30Programs.DateTimeOperations
{
    class Program_96_AgeCalculator
    {
        static void Main(string[] args)
        {
            DateTime dateOfBirth = new DateTime(1998, 9, 15);
            DateTime today = DateTime.Today;
            int age = today.Year - dateOfBirth.Year;
            if (dateOfBirth.Date > today.AddYears(-age))
            {
                age--;
            }
            Console.WriteLine($"Date of Birth: {dateOfBirth:dd/MM/yyyy}");
            Console.WriteLine($"Today: {today:dd/MM/yyyy}");
            Console.WriteLine($"Age: {age} years");
        }
    }
}
