// ============================================
// Program #16 — AbstractClass
// Category  : 02_OOP
// Difficulty: Intermediate
// Description: Use an abstract Vehicle class with concrete implementations
// ============================================

using System;

namespace CSharp30Programs.OOP
{
    abstract class Vehicle
    {
        public string Brand { get; }

        protected Vehicle(string brand)
        {
            Brand = brand;
        }

        public abstract string FuelType();
    }

    class ElectricCar : Vehicle
    {
        public ElectricCar(string brand) : base(brand)
        {
        }

        public override string FuelType()
        {
            return "Electric";
        }
    }

    class PetrolCar : Vehicle
    {
        public PetrolCar(string brand) : base(brand)
        {
        }

        public override string FuelType()
        {
            return "Petrol";
        }
    }

    class Program_16_AbstractClass
    {
        static void Main(string[] args)
        {
            Vehicle electric = new ElectricCar("Tesla");
            Vehicle petrol = new PetrolCar("Toyota");

            Console.WriteLine($"{electric.Brand} uses {electric.FuelType()} power.");
            Console.WriteLine($"{petrol.Brand} uses {petrol.FuelType()} power.");
        }
    }
}
