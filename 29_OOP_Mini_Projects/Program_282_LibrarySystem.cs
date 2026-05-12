// ============================================
// Program #282 — LibrarySystem
// Category  : 29_OOP_Mini_Projects
// Difficulty: [Intermediate]
// Description: Library system for adding, searching, issuing, and returning books.
// ============================================

using System;

namespace CSharp30Programs.OOPMiniProjects
{
    class Program_282_LibrarySystem
    {
        class Book
        {
            public string Isbn { get; }
            public string Title { get; }
            public bool IsIssued { get; private set; }
            public Book(string isbn, string title) { Isbn = isbn; Title = title; }
            public bool Issue() { if (IsIssued) return false; IsIssued = true; return true; }
            public bool Return() { if (!IsIssued) return false; IsIssued = false; return true; }
        }

        static void Main(string[] args)
        {
            var books = new System.Collections.Generic.List<Book>
            {
                new Book("B101", "C# in Depth"),
                new Book("B102", "Clean Code"),
                new Book("B103", "Algorithms Made Easy")
            };

            while (true)
            {
                Console.WriteLine("\n1.Search 2.Issue 3.Return 4.List 5.Exit");
                Console.Write("Choose: ");
                string c = (Console.ReadLine() ?? "").Trim();
                if (c == "5") break;

                if (c == "1")
                {
                    Console.Write("Keyword: ");
                    string k = (Console.ReadLine() ?? "").Trim();
                    foreach (var b in books) if (b.Title.IndexOf(k, StringComparison.OrdinalIgnoreCase) >= 0) Console.WriteLine($"{b.Isbn} - {b.Title} ({(b.IsIssued ? "Issued" : "Available")})");
                }
                else if (c == "2" || c == "3")
                {
                    Console.Write("ISBN: ");
                    string isbn = (Console.ReadLine() ?? "").Trim();
                    Book book = books.Find(b => b.Isbn.Equals(isbn, StringComparison.OrdinalIgnoreCase));
                    if (book == null) { Console.WriteLine("Book not found."); continue; }
                    bool ok = c == "2" ? book.Issue() : book.Return();
                    Console.WriteLine(ok ? "Success." : "Operation not allowed.");
                }
                else if (c == "4")
                {
                    foreach (var b in books) Console.WriteLine($"{b.Isbn} - {b.Title} ({(b.IsIssued ? "Issued" : "Available")})");
                }
            }
            Console.WriteLine("Library app closed.");
        }
    }
}
