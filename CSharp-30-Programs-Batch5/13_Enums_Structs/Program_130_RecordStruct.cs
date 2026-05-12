// ============================================
// Program #130 — RecordStruct
// Category  : 13_Enums_Structs
// Difficulty: Intermediate
// Description: Use a C# 10 record struct with positional parameters
// ============================================

using System;

namespace CSharp30Programs.EnumsStructs
{
    class Program_130_RecordStruct
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(101, "Asha", "Developer");
            Console.WriteLine($"Employee: {employee}");

            Employee promoted = employee with { Role = "Senior Developer" };
            Console.WriteLine($"Promoted: {promoted}");
        }


        readonly record struct Employee(int Id, string Name, string Role);
    }
}
