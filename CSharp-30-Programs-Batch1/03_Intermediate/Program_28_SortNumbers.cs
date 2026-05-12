// ============================================
// Program #28 — SortNumbers
// Category  : 03_Intermediate
// Difficulty: Intermediate
// Description: Sort a list of numbers entered by the user
// ============================================

using System;
using System.Collections.Generic;

namespace CSharp30Programs.Intermediate
{
    class Program_28_SortNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter comma-separated numbers:");
            string input = Console.ReadLine() ?? string.Empty;

            List<int> numbers = new List<int>();
            foreach (string part in input.Split(',', StringSplitOptions.RemoveEmptyEntries))
            {
                if (int.TryParse(part.Trim(), out int value))
                {
                    numbers.Add(value);
                }
            }

            if (numbers.Count == 0)
            {
                numbers.AddRange(new[] { 5, 2, 9, 1 });
                Console.WriteLine("No valid input detected. Using default numbers.");
            }

            Console.WriteLine("Original: " + string.Join(", ", numbers));
            numbers.Sort();
            Console.WriteLine("Sorted: " + string.Join(", ", numbers));
        }
    }
}
