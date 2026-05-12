// ============================================
// Program #178 — TypePatternWithInheritance
// Category  : 18_Nullable_PatternMatching
// Difficulty: Intermediate
// Description: Uses type patterns with inheritance hierarchy
// ============================================

using System;

namespace CSharp30Programs.NullablePatternMatching
{
    class Program_178_TypePatternWithInheritance
    {
        static void Main(string[] args)
        {
            Animal animal = new Dog { Name = "Bruno" };
            string sound = animal switch
            {
                Dog d => $"{d.Name} says Woof",
                Cat c => $"{c.Name} says Meow",
                _ => "Unknown animal"
            };

            Console.WriteLine(sound);
        }

        abstract class Animal
        {
            public string Name { get; set; } = string.Empty;
        }

        class Dog : Animal { }
        class Cat : Animal { }
    }
}
