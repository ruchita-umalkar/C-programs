// ============================================
// Program #187 — IComparableDemo
// Category  : 19_Advanced_OOP
// Difficulty: Intermediate
// Description: Sorts students by marks using IComparable
// ============================================

using System;

namespace CSharp30Programs.AdvancedOOP
{
    class Student : IComparable<Student>
    {
        public string Name { get; }
        public int Marks { get; }

        public Student(string name, int marks)
        {
            Name = name;
            Marks = marks;
        }

        public int CompareTo(Student other)
        {
            if (other == null) return 1;
            return Marks.CompareTo(other.Marks);
        }

        public override string ToString() => $"{Name} - {Marks}";
    }

    class Program_187_IComparableDemo
    {
        static void Main(string[] args)
        {
            var students = new[]
            {
                new Student("Anya", 78),
                new Student("Ravi", 92),
                new Student("Luis", 85)
            };

            Array.Sort(students);

            Console.WriteLine("Students sorted by marks (ascending):");
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
}
