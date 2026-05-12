// ============================================
// Program #280 — CurrencyConverter
// Category  : 28_Console_Mini_Projects
// Difficulty: [Intermediate]
// Description: Currency converter with hardcoded exchange rates.
// ============================================

using System;

namespace CSharp30Programs.ConsoleMiniProjects
{
    class Program_280_CurrencyConverter
    {
        static void Main(string[] args)
        {
            var rates = new System.Collections.Generic.Dictionary<string, decimal>(StringComparer.OrdinalIgnoreCase)
            {
                ["USD"] = 1m,
                ["EUR"] = 0.92m,
                ["INR"] = 83.20m,
                ["JPY"] = 153.10m,
                ["GBP"] = 0.79m
            };

            while (true)
            {
                Console.WriteLine("\nSupported: USD, EUR, INR, JPY, GBP");
                Console.Write("From currency (or EXIT): ");
                string from = (Console.ReadLine() ?? "").Trim().ToUpper();
                if (from == "EXIT") break;
                Console.Write("To currency: ");
                string to = (Console.ReadLine() ?? "").Trim().ToUpper();
                Console.Write("Amount: ");
                if (!decimal.TryParse(Console.ReadLine(), out decimal amount) || amount < 0)
                {
                    Console.WriteLine("Invalid amount.");
                    continue;
                }
                if (!rates.ContainsKey(from) || !rates.ContainsKey(to))
                {
                    Console.WriteLine("Unsupported currency code.");
                    continue;
                }
                decimal usd = amount / rates[from];
                decimal converted = usd * rates[to];
                Console.WriteLine($"{amount} {from} = {converted:F2} {to}");
            }
            Console.WriteLine("Currency converter closed.");
        }
    }
}
