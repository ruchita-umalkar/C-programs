// ============================================
// Program #277 — UnitConverterApp
// Category  : 28_Console_Mini_Projects
// Difficulty: [Intermediate]
// Description: Unit converter for length, weight, and temperature.
// ============================================

using System;

namespace CSharp30Programs.ConsoleMiniProjects
{
    class Program_277_UnitConverterApp
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n1.Length(km<->miles) 2.Weight(kg<->lb) 3.Temp(C<->F) 4.Exit");
                Console.Write("Choose: ");
                string choice = (Console.ReadLine() ?? "").Trim();
                if (choice == "4") break;
                Console.Write("Enter value: ");
                if (!double.TryParse(Console.ReadLine(), out double value)) { Console.WriteLine("Invalid value."); continue; }

                if (choice == "1")
                {
                    Console.WriteLine($"{value} km = {value * 0.621371:F3} miles");
                    Console.WriteLine($"{value} miles = {value / 0.621371:F3} km");
                }
                else if (choice == "2")
                {
                    Console.WriteLine($"{value} kg = {value * 2.20462:F3} lb");
                    Console.WriteLine($"{value} lb = {value / 2.20462:F3} kg");
                }
                else if (choice == "3")
                {
                    Console.WriteLine($"{value}°C = {(value * 9 / 5) + 32:F2}°F");
                    Console.WriteLine($"{value}°F = {(value - 32) * 5 / 9:F2}°C");
                }
                else Console.WriteLine("Invalid option.");
            }
            Console.WriteLine("Converter closed.");
        }
    }
}
