// ============================================
// Program #286 — ShoppingCartSystem
// Category  : 29_OOP_Mini_Projects
// Difficulty: [Intermediate]
// Description: Shopping cart with item management, discount, and final bill.
// ============================================

using System;

namespace CSharp30Programs.OOPMiniProjects
{
    class Program_286_ShoppingCartSystem
    {
        class CartItem
        {
            public string Name { get; }
            public decimal Price { get; }
            public int Qty { get; set; }
            public CartItem(string name, decimal price, int qty) { Name = name; Price = price; Qty = qty; }
            public decimal Total => Price * Qty;
        }

        static void Main(string[] args)
        {
            var cart = new System.Collections.Generic.Dictionary<string, CartItem>(StringComparer.OrdinalIgnoreCase);
            while (true)
            {
                Console.WriteLine("\n1.Add 2.Remove 3.View 4.Bill 5.Exit");
                Console.Write("Choose: ");
                string c = (Console.ReadLine() ?? "").Trim();
                if (c == "5") break;

                if (c == "1")
                {
                    Console.Write("Item name: "); string name = (Console.ReadLine() ?? "").Trim();
                    Console.Write("Price: "); decimal.TryParse(Console.ReadLine(), out decimal price);
                    Console.Write("Qty: "); int.TryParse(Console.ReadLine(), out int qty);
                    if (name.Length > 0 && price > 0 && qty > 0)
                    {
                        if (cart.ContainsKey(name)) cart[name].Qty += qty;
                        else cart[name] = new CartItem(name, price, qty);
                    }
                }
                else if (c == "2")
                {
                    Console.Write("Item name: ");
                    string name = (Console.ReadLine() ?? "").Trim();
                    Console.WriteLine(cart.Remove(name) ? "Removed." : "Not found.");
                }
                else if (c == "3")
                {
                    foreach (var i in cart.Values) Console.WriteLine($"{i.Name} x{i.Qty} = {i.Total:C}");
                }
                else if (c == "4")
                {
                    decimal subtotal = 0m;
                    foreach (var i in cart.Values) subtotal += i.Total;
                    decimal discount = subtotal >= 1000m ? subtotal * 0.10m : 0m;
                    decimal total = subtotal - discount;
                    Console.WriteLine($"Subtotal: {subtotal:C}");
                    Console.WriteLine($"Discount: {discount:C}");
                    Console.WriteLine($"Payable: {total:C}");
                }
            }
            Console.WriteLine("Shopping cart closed.");
        }
    }
}
