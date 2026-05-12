// ============================================
// Program #14 — Polymorphism
// Category  : 02_OOP
// Difficulty: Basic
// Description: Calculate areas with polymorphic Shape classes
// ============================================

using System;

namespace CSharp30Programs.OOP
{
    class Shape
    {
        public virtual double Area()
        {
            return 0;
        }
    }

    class Circle : Shape
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }

    class Rectangle : Shape
    {
        public double Width { get; }
        public double Height { get; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return Width * Height;
        }
    }

    class Program_14_Polymorphism
    {
        static void Main(string[] args)
        {
            Shape[] shapes =
            {
                new Circle(3),
                new Rectangle(4, 5)
            };

            foreach (Shape shape in shapes)
            {
                Console.WriteLine($"{shape.GetType().Name} area: {shape.Area():0.00}");
            }
        }
    }
}
