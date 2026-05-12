// ============================================
// Program #12 — Constructors
// Category  : 02_OOP
// Difficulty: Basic
// Description: Demonstrate default and parameterized constructors
// ============================================

using System;

namespace CSharp30Programs.OOP
{
    class Person
    {
        public string Name { get; }
        public int Age { get; }

        public Person()
        {
            Name = "Unknown";
            Age = 0;
            Console.WriteLine("Default constructor called.");
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            Console.WriteLine("Parameterized constructor called.");
        }

        public void Introduce()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }

    class Program_12_Constructors
    {
        static void Main(string[] args)
        {
            Person first = new Person();
            first.Introduce();

            Person second = new Person("Alex", 28);
            second.Introduce();
        }
    }
}
