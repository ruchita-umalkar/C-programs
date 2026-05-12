// ============================================
// Program #69 — CustomObjectList
// Category  : 07_Collections
// Difficulty: Intermediate
// Description: Use a List of custom objects and filter results
// ============================================

using System;
using System.Collections.Generic;

namespace CSharp30Programs._07_Collections
{
    class Program_69_CustomObjectList
    {
        static void Main(string[] args)
        {
            var employees = new List<Employee>
            {
                new Employee("Asha", 50000),
                new Employee("Ravi", 65000),
                new Employee("Meera", 48000)
            };
            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.Name} - {employee.Salary}");
            }
            var highEarners = employees.FindAll(e => e.Salary >= 50000);
            Console.WriteLine($"High earners count: {highEarners.Count}");
        }

        private record Employee(string Name, decimal Salary);
    }
}
