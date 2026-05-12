// ============================================
// Program #74 — LINQJoin
// Category  : 08_LINQ
// Difficulty: Intermediate
// Description: Join two collections based on related keys
// ============================================

using System;
using System.Linq;

namespace CSharp30Programs._08_LINQ
{
    class Program_74_LINQJoin
    {
        static void Main(string[] args)
        {
            var students = new[]
            {
                new { Id = 1, Name = "Asha" },
                new { Id = 2, Name = "Ravi" }
            };
            var marks = new[]
            {
                new { StudentId = 1, Score = 92 },
                new { StudentId = 2, Score = 85 }
            };
            var result = students.Join(marks, s => s.Id, m => m.StudentId, (s, m) => new { s.Name, m.Score });
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Name}: {item.Score}");
            }
        }
    }
}
