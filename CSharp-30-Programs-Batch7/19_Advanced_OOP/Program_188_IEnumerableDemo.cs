// ============================================
// Program #188 — IEnumerableDemo
// Category  : 19_Advanced_OOP
// Difficulty: Intermediate
// Description: Implements IEnumerable for a custom collection
// ============================================

using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharp30Programs.AdvancedOOP
{
    class NumberCollection : IEnumerable<int>
    {
        private readonly List<int> _numbers = new List<int>();

        public void Add(int number) => _numbers.Add(number);

        public IEnumerator<int> GetEnumerator()
        {
            foreach (var number in _numbers)
            {
                yield return number;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    class Program_188_IEnumerableDemo
    {
        static void Main(string[] args)
        {
            var collection = new NumberCollection();
            collection.Add(3);
            collection.Add(6);
            collection.Add(9);

            Console.WriteLine("Iterating over custom collection:");
            foreach (var number in collection)
            {
                Console.WriteLine(number);
            }
        }
    }
}
