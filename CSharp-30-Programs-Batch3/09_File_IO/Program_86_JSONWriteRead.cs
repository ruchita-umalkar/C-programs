// ============================================
// Program #86 — JSONWriteRead
// Category  : 09_File_IO
// Difficulty: Intermediate
// Description: Serialize and deserialize JSON data using System.Text.Json
// ============================================

using System;
using System.IO;
using System.Text.Json;

namespace CSharp30Programs._09_File_IO
{
    class Program_86_JSONWriteRead
    {
        static void Main(string[] args)
        {
            string path = Path.Combine(Path.GetTempPath(), "program86.json");
            var student = new Student("Neha", 21);
            string json = JsonSerializer.Serialize(student);
            File.WriteAllText(path, json);
            string loadedJson = File.ReadAllText(path);
            var loadedStudent = JsonSerializer.Deserialize<Student>(loadedJson);
            Console.WriteLine($"JSON: {loadedJson}");
            Console.WriteLine($"Loaded: {loadedStudent?.Name}, {loadedStudent?.Age}");
        }

        private record Student(string Name, int Age);
    }
}
