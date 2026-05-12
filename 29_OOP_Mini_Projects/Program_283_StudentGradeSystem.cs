// ============================================
// Program #283 — StudentGradeSystem
// Category  : 29_OOP_Mini_Projects
// Difficulty: [Intermediate]
// Description: Student marks system with average, grade, and rank.
// ============================================

using System;

namespace CSharp30Programs.OOPMiniProjects
{
    class Program_283_StudentGradeSystem
    {
        class Student
        {
            public string Name { get; }
            public int Marks { get; }
            public Student(string name, int marks) { Name = name; Marks = marks; }
            public string Grade => Marks >= 90 ? "A" : Marks >= 75 ? "B" : Marks >= 60 ? "C" : Marks >= 40 ? "D" : "F";
        }

        static void Main(string[] args)
        {
            var students = new System.Collections.Generic.List<Student>
            {
                new Student("Ava", 88),
                new Student("Ben", 72),
                new Student("Cara", 95),
                new Student("Dan", 64)
            };

            students.Sort((a, b) => b.Marks.CompareTo(a.Marks));
            int total = 0;
            for (int i = 0; i < students.Count; i++)
            {
                total += students[i].Marks;
                Console.WriteLine($"Rank {i + 1}: {students[i].Name} - {students[i].Marks} ({students[i].Grade})");
            }
            Console.WriteLine($"Class average: {(double)total / students.Count:F2}");
        }
    }
}
