// ============================================
// Program #135 — GenericRepository
// Category  : 14_Generics
// Difficulty: Intermediate
// Description: Build a simple in-memory generic repository
// ============================================

using System;

namespace CSharp30Programs.Generics
{
    class Program_135_GenericRepository
    {
        static void Main(string[] args)
        {
            Repository<int> repository = new Repository<int>();
            repository.Add(10);
            repository.Add(20);
            repository.Add(30);

            Console.WriteLine("Repository values:");
            foreach (int item in repository.GetAll())
            {
                Console.WriteLine($"- {item}");
            }
        }


        class Repository<T>
        {
            private readonly System.Collections.Generic.List<T> _items = new System.Collections.Generic.List<T>();

            public void Add(T item) => _items.Add(item);
            public System.Collections.Generic.IEnumerable<T> GetAll() => _items;
        }
    }
}
