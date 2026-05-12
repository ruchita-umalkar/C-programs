// ============================================
// Program #190 — RecordTypes
// Category  : 19_Advanced_OOP
// Difficulty: Intermediate
// Description: Demonstrates record types with immutability and equality
// ============================================

using System;

namespace CSharp30Programs.AdvancedOOP
{
    record Person(string Name, int Age);

    class Program_190_RecordTypes
    {
        static void Main(string[] args)
        {
            var person1 = new Person("Nina", 30);
            var person2 = person1 with { Age = 31 };
            var person3 = new Person("Nina", 30);

            Console.WriteLine($"Original: {person1}");
            Console.WriteLine($"Modified with 'with': {person2}");
            Console.WriteLine($"Value equality (person1 == person3): {person1 == person3}");
        }
    }
}
