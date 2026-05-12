// ============================================
// Program #2 — UserInput
// Category  : 01_Basics
// Difficulty: Basic
// Description: Ask for name and age, then greet the user
// ============================================

using System;

namespace CSharp30Programs.Basics
{
    class Program_2_UserInput
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine() ?? "Guest";

            Console.WriteLine("Enter your age:");
            string ageInput = Console.ReadLine();
            int age;
            if (!int.TryParse(ageInput, out age))
            {
                age = 0;
            }

            Console.WriteLine($"Hello {name}, you are {age} years old.");
        }
    }
}
