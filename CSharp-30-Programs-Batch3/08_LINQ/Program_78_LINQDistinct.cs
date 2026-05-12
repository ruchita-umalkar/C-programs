// ============================================
// Program #78 — LINQDistinct
// Category  : 08_LINQ
// Difficulty: Basic
// Description: Remove duplicate values using Distinct
// ============================================

using System;
using System.Linq;

namespace CSharp30Programs._08_LINQ
{
    class Program_78_LINQDistinct
    {
        static void Main(string[] args)
        {
            var cities = new[] { "Pune", "Mumbai", "Pune", "Delhi" };
            var uniqueCities = cities.Distinct();
            Console.WriteLine($"Unique cities: {string.Join(", ", uniqueCities)}");
        }
    }
}
