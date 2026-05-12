// ============================================
// Program #289 — SchoolManagement
// Category  : 29_OOP_Mini_Projects
// Difficulty: [Intermediate]
// Description: School model with Teacher, Student, and Subject classes.
// ============================================

using System;

namespace CSharp30Programs.OOPMiniProjects
{
    class Program_289_SchoolManagement
    {
        class Subject
        {
            public string Name { get; }
            public Subject(string name) { Name = name; }
        }

        class Teacher
        {
            public string Name { get; }
            public Subject Subject { get; }
            public Teacher(string name, Subject subject) { Name = name; Subject = subject; }
        }

        class Student
        {
            public string Name { get; }
            public System.Collections.Generic.List<Subject> Subjects { get; } = new System.Collections.Generic.List<Subject>();
            public Student(string name) { Name = name; }
        }

        static void Main(string[] args)
        {
            var math = new Subject("Mathematics");
            var science = new Subject("Science");
            var t1 = new Teacher("Mr. Green", math);
            var t2 = new Teacher("Ms. Blue", science);

            var s1 = new Student("Liam");
            s1.Subjects.Add(math);
            s1.Subjects.Add(science);

            Console.WriteLine($"Teachers: {t1.Name}({t1.Subject.Name}), {t2.Name}({t2.Subject.Name})");
            Console.WriteLine($"Student: {s1.Name}");
            foreach (var sub in s1.Subjects) Console.WriteLine($"Enrolled: {sub.Name}");
        }
    }
}
