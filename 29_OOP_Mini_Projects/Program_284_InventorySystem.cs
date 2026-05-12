// ============================================
// Program #284 — InventorySystem
// Category  : 29_OOP_Mini_Projects
// Difficulty: [Intermediate]
// Description: Inventory system with add, remove, search, and restock features.
// ============================================

using System;

namespace CSharp30Programs.OOPMiniProjects
{
    class Program_284_InventorySystem
    {
        class Product
        {
            public string Code { get; }
            public string Name { get; }
            public int Stock { get; private set; }
            public Product(string code, string name, int stock) { Code = code; Name = name; Stock = stock; }
            public void Restock(int qty) { if (qty > 0) Stock += qty; }
        }

        static void Main(string[] args)
        {
            var items = new System.Collections.Generic.Dictionary<string, Product>(StringComparer.OrdinalIgnoreCase);
            items["P1"] = new Product("P1", "Keyboard", 10);
            items["P2"] = new Product("P2", "Mouse", 15);

            while (true)
            {
                Console.WriteLine("\n1.Add 2.Remove 3.Search 4.Restock 5.List 6.Exit");
                Console.Write("Choose: ");
                string c = (Console.ReadLine() ?? "").Trim();
                if (c == "6") break;

                if (c == "1")
                {
                    Console.Write("Code: "); string code = (Console.ReadLine() ?? "").Trim();
                    Console.Write("Name: "); string name = (Console.ReadLine() ?? "").Trim();
                    Console.Write("Stock: ");
                    if (int.TryParse(Console.ReadLine(), out int stock) && code.Length > 0 && name.Length > 0) items[code] = new Product(code, name, stock);
                }
                else if (c == "2")
                {
                    Console.Write("Code: "); string code = (Console.ReadLine() ?? "").Trim();
                    Console.WriteLine(items.Remove(code) ? "Removed." : "Not found.");
                }
                else if (c == "3")
                {
                    Console.Write("Code: "); string code = (Console.ReadLine() ?? "").Trim();
                    Console.WriteLine(items.TryGetValue(code, out Product p) ? $"{p.Code} {p.Name} Stock={p.Stock}" : "Not found.");
                }
                else if (c == "4")
                {
                    Console.Write("Code: "); string code = (Console.ReadLine() ?? "").Trim();
                    Console.Write("Qty: ");
                    if (items.TryGetValue(code, out Product p) && int.TryParse(Console.ReadLine(), out int qty)) { p.Restock(qty); Console.WriteLine("Restocked."); }
                }
                else if (c == "5")
                {
                    foreach (var p in items.Values) Console.WriteLine($"{p.Code} {p.Name} Stock={p.Stock}");
                }
            }
            Console.WriteLine("Inventory app closed.");
        }
    }
}
