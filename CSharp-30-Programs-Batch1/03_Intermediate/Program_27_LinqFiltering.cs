// ============================================
// Program #27 — LinqFiltering
// Category  : 03_Intermediate
// Difficulty: Intermediate
// Description: Filter even numbers from a list using LINQ
// ============================================

using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp30Programs.Intermediate
{
    class Program_27_LinqFiltering
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Numbers: " + string.Join(", ", numbers));

            List<int> evens = numbers.Where(number => number % 2 == 0).ToList();
            Console.WriteLine("Even numbers: " + string.Join(", ", evens));
        }
    }
}
