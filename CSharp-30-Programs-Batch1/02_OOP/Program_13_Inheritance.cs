// ============================================
// Program #13 — Inheritance
// Category  : 02_OOP
// Difficulty: Basic
// Description: Demonstrate inheritance with Animal, Dog, and Cat classes
// ============================================

using System;

namespace CSharp30Programs.OOP
{
    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("Animal makes a sound.");
        }
    }

    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Dog says: Woof!");
        }
    }

    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Cat says: Meow!");
        }
    }

    class Program_13_Inheritance
    {
        static void Main(string[] args)
        {
            Animal baseAnimal = new Animal();
            baseAnimal.Speak();

            Animal dog = new Dog();
            dog.Speak();

            Animal cat = new Cat();
            cat.Speak();
        }
    }
}
