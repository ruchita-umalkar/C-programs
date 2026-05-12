// ============================================
// Program #182 — AbstractFactory
// Category  : 19_Advanced_OOP
// Difficulty: Intermediate
// Description: Uses abstract factories to create different shapes
// ============================================

using System;

namespace CSharp30Programs.AdvancedOOP
{
    abstract class Shape
    {
        public abstract void Draw();
    }

    class Circle : Shape
    {
        public override void Draw() => Console.WriteLine("Drawing Circle");
    }

    class Rectangle : Shape
    {
        public override void Draw() => Console.WriteLine("Drawing Rectangle");
    }

    class Triangle : Shape
    {
        public override void Draw() => Console.WriteLine("Drawing Triangle");
    }

    abstract class ShapeFactory
    {
        public abstract Shape CreateShape();
    }

    class CircleFactory : ShapeFactory
    {
        public override Shape CreateShape() => new Circle();
    }

    class RectangleFactory : ShapeFactory
    {
        public override Shape CreateShape() => new Rectangle();
    }

    class TriangleFactory : ShapeFactory
    {
        public override Shape CreateShape() => new Triangle();
    }

    class Program_182_AbstractFactory
    {
        static void Main(string[] args)
        {
            ShapeFactory[] factories =
            {
                new CircleFactory(),
                new RectangleFactory(),
                new TriangleFactory()
            };

            foreach (var factory in factories)
            {
                Shape shape = factory.CreateShape();
                shape.Draw();
            }
        }
    }
}
