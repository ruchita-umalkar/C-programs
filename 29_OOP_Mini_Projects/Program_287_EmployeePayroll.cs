// ============================================
// Program #287 — EmployeePayroll
// Category  : 29_OOP_Mini_Projects
// Difficulty: [Intermediate]
// Description: Employee payroll with gross salary, tax, and net pay calculation.
// ============================================

using System;

namespace CSharp30Programs.OOPMiniProjects
{
    class Program_287_EmployeePayroll
    {
        class Employee
        {
            public string Name { get; }
            public decimal Basic { get; }
            public decimal Allowance { get; }
            public Employee(string name, decimal basic, decimal allowance) { Name = name; Basic = basic; Allowance = allowance; }
            public decimal Gross => Basic + Allowance;
            public decimal Tax => Gross > 50000m ? Gross * 0.20m : Gross > 25000m ? Gross * 0.10m : Gross * 0.05m;
            public decimal Net => Gross - Tax;
        }

        static void Main(string[] args)
        {
            var employees = new System.Collections.Generic.List<Employee>
            {
                new Employee("Ivy", 30000m, 5000m),
                new Employee("Jack", 55000m, 7000m),
                new Employee("Kim", 22000m, 3000m)
            };

            foreach (var e in employees)
            {
                Console.WriteLine($"{e.Name}: Gross={e.Gross:C}, Tax={e.Tax:C}, Net={e.Net:C}");
            }
        }
    }
}
