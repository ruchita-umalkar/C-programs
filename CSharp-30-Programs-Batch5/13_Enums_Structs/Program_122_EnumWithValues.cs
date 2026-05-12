// ============================================
// Program #122 — EnumWithValues
// Category  : 13_Enums_Structs
// Difficulty: Basic
// Description: Enum with custom integer values and casting to int
// ============================================

using System;

namespace CSharp30Programs.EnumsStructs
{
    class Program_122_EnumWithValues
    {
        static void Main(string[] args)
        {
            HttpStatus status = HttpStatus.NotFound;
            Console.WriteLine($"Status: {status}");
            Console.WriteLine($"Code: {(int)status}");
        }


        enum HttpStatus { Success = 200, NotFound = 404, ServerError = 500 }
    }
}
