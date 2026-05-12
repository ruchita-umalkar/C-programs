// ============================================
// Program #133 — GenericConstraints
// Category  : 14_Generics
// Difficulty: Intermediate
// Description: Use generic constraints with class and new()
// ============================================

using System;

namespace CSharp30Programs.Generics
{
    class Program_133_GenericConstraints
    {
        static void Main(string[] args)
        {
            Box<Person> personBox = new Box<Person>();
            Person person = personBox.Create();
            person.Name = "Kiran";
            Console.WriteLine($"Created person: {person.Name}");
        }


        class Person
        {
            public string Name { get; set; } = string.Empty;
        }

        class Box<T> where T : class, new()
        {
            public T Create()
            {
                return new T();
            }
        }
    }
}
