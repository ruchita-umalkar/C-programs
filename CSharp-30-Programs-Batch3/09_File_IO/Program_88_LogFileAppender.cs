// ============================================
// Program #88 — LogFileAppender
// Category  : 09_File_IO
// Difficulty: Basic
// Description: Append log entries to a text file
// ============================================

using System;
using System.IO;

namespace CSharp30Programs._09_File_IO
{
    class Program_88_LogFileAppender
    {
        static void Main(string[] args)
        {
            string path = Path.Combine(Path.GetTempPath(), "program88.log");
            File.AppendAllText(path, $"[{DateTime.Now:O}] Application started{Environment.NewLine}");
            File.AppendAllText(path, $"[{DateTime.Now:O}] Operation completed{Environment.NewLine}");
            string[] lines = File.ReadAllLines(path);
            Console.WriteLine($"Log entries: {lines.Length}");
            Console.WriteLine(lines[^1]);
        }
    }
}
