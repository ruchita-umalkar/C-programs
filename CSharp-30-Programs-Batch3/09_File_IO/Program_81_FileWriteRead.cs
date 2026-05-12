// ============================================
// Program #81 — FileWriteRead
// Category  : 09_File_IO
// Difficulty: Basic
// Description: Write text to a file and read it back
// ============================================

using System;
using System.IO;

namespace CSharp30Programs._09_File_IO
{
    class Program_81_FileWriteRead
    {
        static void Main(string[] args)
        {
            string path = Path.Combine(Path.GetTempPath(), "program81.txt");
            File.WriteAllText(path, "Hello from Program 81");
            string content = File.ReadAllText(path);
            Console.WriteLine($"Read content: {content}");
        }
    }
}
