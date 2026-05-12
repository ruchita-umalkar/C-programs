// ============================================
// Program #125 — EnumIteration
// Category  : 13_Enums_Structs
// Difficulty: Basic
// Description: Iterate all enum values using Enum.GetValues
// ============================================

using System;

namespace CSharp30Programs.EnumsStructs
{
    class Program_125_EnumIteration
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Order states:");
            foreach (OrderState state in Enum.GetValues(typeof(OrderState)))
            {
                Console.WriteLine($"- {state} ({(int)state})");
            }
        }


        enum OrderState { Created = 1, Packed = 2, Shipped = 3, Delivered = 4 }
    }
}
