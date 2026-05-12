// ============================================
// Program #276 — ContactBook
// Category  : 28_Console_Mini_Projects
// Difficulty: [Intermediate]
// Description: Contact book with add, search, and delete using Dictionary.
// ============================================

using System;

namespace CSharp30Programs.ConsoleMiniProjects
{
    class Program_276_ContactBook
    {
        static void Main(string[] args)
        {
            var contacts = new System.Collections.Generic.Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            while (true)
            {
                Console.WriteLine("\n1.Add 2.Search 3.Delete 4.ViewAll 5.Exit");
                Console.Write("Choose: ");
                string choice = (Console.ReadLine() ?? "").Trim();
                if (choice == "1")
                {
                    Console.Write("Name: ");
                    string name = (Console.ReadLine() ?? "").Trim();
                    Console.Write("Phone: ");
                    string phone = (Console.ReadLine() ?? "").Trim();
                    if (name.Length > 0 && phone.Length > 0) { contacts[name] = phone; Console.WriteLine("Saved."); }
                }
                else if (choice == "2")
                {
                    Console.Write("Name to search: ");
                    string name = (Console.ReadLine() ?? "").Trim();
                    if (contacts.TryGetValue(name, out string phone)) Console.WriteLine($"{name}: {phone}");
                    else Console.WriteLine("Not found.");
                }
                else if (choice == "3")
                {
                    Console.Write("Name to delete: ");
                    string name = (Console.ReadLine() ?? "").Trim();
                    Console.WriteLine(contacts.Remove(name) ? "Deleted." : "Not found.");
                }
                else if (choice == "4")
                {
                    Console.WriteLine("--- Contacts ---");
                    if (contacts.Count == 0) Console.WriteLine("No contacts.");
                    foreach (var kv in contacts) Console.WriteLine($"{kv.Key}: {kv.Value}");
                }
                else if (choice == "5") break;
            }
            Console.WriteLine("Contact book closed.");
        }
    }
}
