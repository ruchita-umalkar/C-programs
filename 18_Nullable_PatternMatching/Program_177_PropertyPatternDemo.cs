// ============================================
// Program #177 — PropertyPatternDemo
// Category  : 18_Nullable_PatternMatching
// Difficulty: Intermediate
// Description: Matches object properties using property patterns
// ============================================

using System;

namespace CSharp30Programs.NullablePatternMatching
{
    class Program_177_PropertyPatternDemo
    {
        static void Main(string[] args)
        {
            Person person = new Person { Name = "Asha", Age = 21 };
            string category = person is { Age: >= 18, Name: not null } ? "Adult with valid name" : "Other";

            Console.WriteLine(category);
        }

        class Person
        {
            public string? Name { get; set; }
            public int Age { get; set; }
        }
    }
}
