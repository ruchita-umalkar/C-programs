// ============================================
// Program #128 — ReadonlyStruct
// Category  : 13_Enums_Structs
// Difficulty: Intermediate
// Description: Create readonly struct with immutable fields
// ============================================

using System;

namespace CSharp30Programs.EnumsStructs
{
    class Program_128_ReadonlyStruct
    {
        static void Main(string[] args)
        {
            Temperature t = new Temperature(24.5);
            Console.WriteLine(t);
            Console.WriteLine($"Fahrenheit: {t.ToFahrenheit():F2}");
        }


        readonly struct Temperature
        {
            public double Celsius { get; }

            public Temperature(double celsius)
            {
                Celsius = celsius;
            }

            public double ToFahrenheit()
            {
                return (Celsius * 9 / 5) + 32;
            }

            public override string ToString()
            {
                return $"Celsius: {Celsius:F1}";
            }
        }
    }
}
