// ============================================
// Program #207 — NullRefException
// Category  : 21_Exception_Handling
// Difficulty: Intermediate
// Description: Prevents null reference issues using null checks
// ============================================

using System;

namespace CSharp30Programs.ExceptionHandling
{
    class Person
    {
        public string Name { get; set; }
    }

    class Program_207_NullRefException
    {
        static void Main(string[] args)
        {
            Person person = null;

            if (person == null)
            {
                Console.WriteLine("Person is null, using fallback name.");
            }

            string name = person?.Name ?? "Unknown";
            Console.WriteLine($"Name: {name}");
        }
    }
}
