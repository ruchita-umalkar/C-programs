// ============================================
// Program #18 — MethodOverloading
// Category  : 02_OOP
// Difficulty: Intermediate
// Description: Demonstrate overloaded Add methods in MathHelper
// ============================================

using System;

namespace CSharp30Programs.OOP
{
    class MathHelper
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }

        public string Add(string a, string b)
        {
            return a + b;
        }
    }

    class Program_18_MethodOverloading
    {
        static void Main(string[] args)
        {
            MathHelper helper = new MathHelper();
            string greeting = "Hello ";
            string subject = "World";

            Console.WriteLine($"Add two ints: {helper.Add(4, 5)}");
            Console.WriteLine($"Add three ints: {helper.Add(1, 2, 3)}");
            Console.WriteLine($"Add two doubles: {helper.Add(2.5, 3.7)}");
            Console.WriteLine($"Add two strings: {helper.Add(greeting, subject)}");
        }
    }
}
