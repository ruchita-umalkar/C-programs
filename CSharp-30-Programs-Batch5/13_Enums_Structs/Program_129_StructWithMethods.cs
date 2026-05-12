// ============================================
// Program #129 — StructWithMethods
// Category  : 13_Enums_Structs
// Difficulty: Intermediate
// Description: Struct with constructor, properties and methods
// ============================================

using System;

namespace CSharp30Programs.EnumsStructs
{
    class Program_129_StructWithMethods
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(5, 3);
            Console.WriteLine($"Width={rect.Width}, Height={rect.Height}");
            Console.WriteLine($"Area={rect.Area()}");
            Console.WriteLine($"Perimeter={rect.Perimeter()}");
        }


        struct Rectangle
        {
            public int Width { get; }
            public int Height { get; }

            public Rectangle(int width, int height)
            {
                Width = width;
                Height = height;
            }

            public int Area() => Width * Height;
            public int Perimeter() => 2 * (Width + Height);
        }
    }
}
