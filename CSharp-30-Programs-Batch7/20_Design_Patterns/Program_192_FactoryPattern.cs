// ============================================
// Program #192 — FactoryPattern
// Category  : 20_Design_Patterns
// Difficulty: Intermediate
// Description: Creates animals using a factory method pattern
// ============================================

using System;

namespace CSharp30Programs.DesignPatterns
{
    interface IAnimal
    {
        void Speak();
    }

    class Dog : IAnimal
    {
        public void Speak() => Console.WriteLine("Dog: Woof!");
    }

    class Cat : IAnimal
    {
        public void Speak() => Console.WriteLine("Cat: Meow!");
    }

    class Bird : IAnimal
    {
        public void Speak() => Console.WriteLine("Bird: Tweet!");
    }

    class AnimalFactory
    {
        public IAnimal CreateAnimal(string type)
        {
            return type.ToLowerInvariant() switch
            {
                "dog" => new Dog(),
                "cat" => new Cat(),
                "bird" => new Bird(),
                _ => throw new ArgumentException("Unknown animal type.")
            };
        }
    }

    class Program_192_FactoryPattern
    {
        static void Main(string[] args)
        {
            var factory = new AnimalFactory();

            foreach (var type in new[] { "dog", "cat", "bird" })
            {
                IAnimal animal = factory.CreateAnimal(type);
                animal.Speak();
            }
        }
    }
}
