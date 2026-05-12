// ============================================
// Program #290 — RestaurantBilling
// Category  : 29_OOP_Mini_Projects
// Difficulty: [Intermediate]
// Description: Restaurant ordering and billing with tax and tip.
// ============================================

using System;

namespace CSharp30Programs.OOPMiniProjects
{
    class Program_290_RestaurantBilling
    {
        class MenuItem
        {
            public string Name { get; }
            public decimal Price { get; }
            public MenuItem(string name, decimal price) { Name = name; Price = price; }
        }

        static void Main(string[] args)
        {
            var menu = new System.Collections.Generic.List<MenuItem>
            {
                new MenuItem("Burger", 120m),
                new MenuItem("Pasta", 180m),
                new MenuItem("Pizza", 250m),
                new MenuItem("Juice", 90m)
            };
            var order = new System.Collections.Generic.List<MenuItem>();

            while (true)
            {
                Console.WriteLine("\nMenu:");
                for (int i = 0; i < menu.Count; i++) Console.WriteLine($"{i + 1}. {menu[i].Name} - {menu[i].Price:C}");
                Console.Write("Select item number (0 to bill): ");
                if (!int.TryParse(Console.ReadLine(), out int choice)) continue;
                if (choice == 0) break;
                if (choice >= 1 && choice <= menu.Count) order.Add(menu[choice - 1]);
            }

            decimal subtotal = 0;
            foreach (var i in order) subtotal += i.Price;
            decimal tax = subtotal * 0.05m;
            decimal tip = subtotal * 0.10m;
            decimal total = subtotal + tax + tip;

            Console.WriteLine($"Items: {order.Count}");
            Console.WriteLine($"Subtotal: {subtotal:C}");
            Console.WriteLine($"Tax (5%): {tax:C}");
            Console.WriteLine($"Tip (10%): {tip:C}");
            Console.WriteLine($"Total Bill: {total:C}");
        }
    }
}
