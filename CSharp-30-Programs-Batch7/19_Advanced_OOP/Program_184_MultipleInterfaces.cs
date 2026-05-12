// ============================================
// Program #184 — MultipleInterfaces
// Category  : 19_Advanced_OOP
// Difficulty: Intermediate
// Description: Implements multiple interfaces in a single class
// ============================================

using System;

namespace CSharp30Programs.AdvancedOOP
{
    interface IBird
    {
        void Fly();
    }

    interface IFish
    {
        void Swim();
    }

    class FlyingFish : IBird, IFish
    {
        public void Fly() => Console.WriteLine("FlyingFish glides above the water.");
        public void Swim() => Console.WriteLine("FlyingFish swims swiftly.");
    }

    class Program_184_MultipleInterfaces
    {
        static void Main(string[] args)
        {
            var fish = new FlyingFish();
            fish.Fly();
            fish.Swim();
        }
    }
}
