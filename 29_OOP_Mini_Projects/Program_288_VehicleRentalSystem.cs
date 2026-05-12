// ============================================
// Program #288 — VehicleRentalSystem
// Category  : 29_OOP_Mini_Projects
// Difficulty: [Intermediate]
// Description: Vehicle rental cost calculator with daily rates and booking days.
// ============================================

using System;

namespace CSharp30Programs.OOPMiniProjects
{
    class Program_288_VehicleRentalSystem
    {
        class Vehicle
        {
            public string Name { get; }
            public decimal DailyRate { get; }
            public bool IsRented { get; private set; }
            public Vehicle(string name, decimal rate) { Name = name; DailyRate = rate; }
            public decimal Rent(int days)
            {
                if (IsRented || days <= 0) return -1m;
                IsRented = true;
                return DailyRate * days;
            }
            public void ReturnVehicle() { IsRented = false; }
        }

        static void Main(string[] args)
        {
            var vehicles = new System.Collections.Generic.List<Vehicle>
            {
                new Vehicle("Bike", 20m),
                new Vehicle("Car", 60m),
                new Vehicle("SUV", 90m)
            };

            while (true)
            {
                Console.WriteLine("\n1.List 2.Rent 3.Return all 4.Exit");
                Console.Write("Choose: ");
                string c = (Console.ReadLine() ?? "").Trim();
                if (c == "4") break;
                if (c == "1")
                {
                    for (int i = 0; i < vehicles.Count; i++) Console.WriteLine($"{i + 1}. {vehicles[i].Name} - {vehicles[i].DailyRate:C}/day ({(vehicles[i].IsRented ? "Rented" : "Available")})");
                }
                else if (c == "2")
                {
                    Console.Write("Vehicle number: "); int.TryParse(Console.ReadLine(), out int idx);
                    Console.Write("Days: "); int.TryParse(Console.ReadLine(), out int days);
                    if (idx >= 1 && idx <= vehicles.Count)
                    {
                        decimal cost = vehicles[idx - 1].Rent(days);
                        Console.WriteLine(cost < 0 ? "Unable to rent." : $"Rental cost: {cost:C}");
                    }
                }
                else if (c == "3")
                {
                    foreach (var v in vehicles) v.ReturnVehicle();
                    Console.WriteLine("All vehicles returned.");
                }
            }
            Console.WriteLine("Vehicle rental closed.");
        }
    }
}
