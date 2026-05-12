// ============================================
// Program #200 — IteratorPattern
// Category  : 20_Design_Patterns
// Difficulty: Intermediate
// Description: Iterates through a custom BookShelf collection
// ============================================

using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharp30Programs.DesignPatterns
{
    class Book
    {
        public string Title { get; }
        public Book(string title) => Title = title;
        public override string ToString() => Title;
    }

    class BookShelf : IEnumerable<Book>
    {
        private readonly List<Book> _books = new List<Book>();

        public void Add(Book book) => _books.Add(book);

        public IEnumerator<Book> GetEnumerator() => new BookIterator(_books);
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    class BookIterator : IEnumerator<Book>
    {
        private readonly List<Book> _books;
        private int _position = -1;

        public BookIterator(List<Book> books)
        {
            _books = books;
        }

        public Book Current => _books[_position];
        object IEnumerator.Current => Current;

        public bool MoveNext()
        {
            _position++;
            return _position < _books.Count;
        }

        public void Reset() => _position = -1;
        public void Dispose() { }
    }

    class Program_200_IteratorPattern
    {
        static void Main(string[] args)
        {
            var shelf = new BookShelf();
            shelf.Add(new Book("Design Patterns"));
            shelf.Add(new Book("Clean Code"));
            shelf.Add(new Book("Refactoring"));

            Console.WriteLine("Books on shelf:");
            foreach (var book in shelf)
            {
                Console.WriteLine(book);
            }
        }
    }
}
