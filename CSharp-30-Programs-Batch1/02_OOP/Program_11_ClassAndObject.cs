// ============================================
// Program #11 — ClassAndObject
// Category  : 02_OOP
// Difficulty: Basic
// Description: Create Car objects with properties and a Drive method
// ============================================

using System;

namespace CSharp30Programs.OOP
{
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Speed { get; set; }

        public void Drive()
        {
            Console.WriteLine($"{Brand} {Model} is driving at {Speed} km/h.");
        }
    }

    class Program_11_ClassAndObject
    {
        static void Main(string[] args)
        {
            Car car1 = new Car { Brand = "Toyota", Model = "Corolla", Speed = 60 };
            Car car2 = new Car { Brand = "Tesla", Model = "Model 3", Speed = 80 };

            car1.Drive();
            car2.Drive();
        }
    }
}
