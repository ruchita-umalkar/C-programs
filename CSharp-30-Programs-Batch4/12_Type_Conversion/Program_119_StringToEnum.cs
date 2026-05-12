// ============================================
// Program #119 — StringToEnum
// Category  : 12_Type_Conversion
// Difficulty: Intermediate
// Description: Parse strings to enum values using Parse and TryParse
// ============================================

using System;

namespace CSharp30Programs.TypeConversion
{
    class Program_119_StringToEnum
    {
        static void Main(string[] args)
        {
            string statusText1 = "Completed";
            string statusText2 = "Pending";
            OrderStatus status1 = (OrderStatus)Enum.Parse(typeof(OrderStatus), statusText1);
            Console.WriteLine($"Enum.Parse result: {status1}");
            if (Enum.TryParse(statusText2, out OrderStatus status2))
            {
                Console.WriteLine($"Enum.TryParse result: {status2}");
            }
            else
            {
                Console.WriteLine("Enum.TryParse failed.");
            }
        }
    }

    enum OrderStatus
    {
        New,
        Pending,
        Completed,
        Cancelled
    }
}
