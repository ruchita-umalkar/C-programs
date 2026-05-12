// ============================================
// Program #186 — ObjectCloning
// Category  : 19_Advanced_OOP
// Difficulty: Intermediate
// Description: Compares shallow and deep object cloning
// ============================================

using System;

namespace CSharp30Programs.AdvancedOOP
{
    class Address
    {
        public string City { get; set; }
    }

    class Person : ICloneable
    {
        public string Name { get; set; }
        public Address Address { get; set; }

        public object Clone() => MemberwiseClone();

        public Person DeepClone()
        {
            return new Person
            {
                Name = Name,
                Address = new Address { City = Address.City }
            };
        }
    }

    class Program_186_ObjectCloning
    {
        static void Main(string[] args)
        {
            var original = new Person { Name = "Maya", Address = new Address { City = "Paris" } };
            var shallow = (Person)original.Clone();
            var deep = original.DeepClone();

            shallow.Address.City = "Berlin";

            Console.WriteLine($"Original city after shallow change: {original.Address.City}");
            Console.WriteLine($"Deep clone city remains: {deep.Address.City}");
        }
    }
}
