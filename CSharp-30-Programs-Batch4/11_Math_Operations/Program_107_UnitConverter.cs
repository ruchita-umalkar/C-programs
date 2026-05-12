// ============================================
// Program #107 — UnitConverter
// Category  : 11_Math_Operations
// Difficulty: Basic
// Description: Convert kilometers, kilograms, and Celsius values
// ============================================

using System;

namespace CSharp30Programs.MathOperations
{
    class Program_107_UnitConverter
    {
        static void Main(string[] args)
        {
            double km = 10;
            double kg = 70;
            double celsius = 30;
            double miles = km * 0.621371;
            double pounds = kg * 2.20462;
            double fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine($"{km} km = {miles:F2} miles");
            Console.WriteLine($"{kg} kg = {pounds:F2} pounds");
            Console.WriteLine($"{celsius}°C = {fahrenheit:F2}°F");
        }
    }
}
