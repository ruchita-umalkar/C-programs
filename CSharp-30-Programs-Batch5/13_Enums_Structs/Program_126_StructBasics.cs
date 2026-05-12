// ============================================
// Program #126 — StructBasics
// Category  : 13_Enums_Structs
// Difficulty: Basic
// Description: Declare a struct with fields and a method
// ============================================

using System;

namespace CSharp30Programs.EnumsStructs
{
    class Program_126_StructBasics
    {
        static void Main(string[] args)
        {
            Point p;
            p.X = 4;
            p.Y = 7;
            Console.WriteLine(p.Display());
        }


        struct Point
        {
            public int X;
            public int Y;

            public string Display()
            {
                return $"Point: ({X}, {Y})";
            }
        }
    }
}
