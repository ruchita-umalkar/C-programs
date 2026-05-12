// ============================================
// Program #21 — ListOperations
// Category  : 03_Intermediate
// Difficulty: Intermediate
// Description: Perform add, remove, sort, search, and display operations on a list
// ============================================

using System;
using System.Collections.Generic;

namespace CSharp30Programs.Intermediate
{
    class Program_21_ListOperations
    {
        static void Main(string[] args)
        {
            List<string> students = new List<string> { "Ava", "Liam", "Noah" };
            Console.WriteLine("Initial list: " + string.Join(", ", students));

            students.Add("Mia");
            Console.WriteLine("After adding Mia: " + string.Join(", ", students));

            students.Remove("Liam");
            Console.WriteLine("After removing Liam: " + string.Join(", ", students));

            students.Sort();
            Console.WriteLine("Sorted list: " + string.Join(", ", students));

            string searchName = "Noah";
            bool found = students.Contains(searchName);
            Console.WriteLine($"Search for {searchName}: {(found ? "Found" : "Not found")}");
        }
    }
}
