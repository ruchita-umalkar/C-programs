// ============================================
// Program #108 — TemperatureConverter
// Category  : 11_Math_Operations
// Difficulty: Basic
// Description: Convert temperatures between Celsius, Fahrenheit, and Kelvin
// ============================================

using System;

namespace CSharp30Programs.MathOperations
{
    class Program_108_TemperatureConverter
    {
        static void Main(string[] args)
        {
            double celsius = 25;
            double fahrenheit = (celsius * 9 / 5) + 32;
            double kelvin = celsius + 273.15;
            double cFromF = (fahrenheit - 32) * 5 / 9;
            double cFromK = kelvin - 273.15;
            Console.WriteLine($"Celsius: {celsius}°C");
            Console.WriteLine($"To Fahrenheit: {fahrenheit:F2}°F");
            Console.WriteLine($"To Kelvin: {kelvin:F2}K");
            Console.WriteLine($"Fahrenheit back to Celsius: {cFromF:F2}°C");
            Console.WriteLine($"Kelvin back to Celsius: {cFromK:F2}°C");
        }
    }
}
