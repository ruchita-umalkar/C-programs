// ============================================
// Program #83 — FileInfoDemo
// Category  : 09_File_IO
// Difficulty: Basic
// Description: Display file metadata using FileInfo
// ============================================

using System;
using System.IO;

namespace CSharp30Programs._09_File_IO
{
    class Program_83_FileInfoDemo
    {
        static void Main(string[] args)
        {
            string path = Path.Combine(Path.GetTempPath(), "program83.txt");
            File.WriteAllText(path, "File info sample");
            var info = new FileInfo(path);
            Console.WriteLine($"Name: {info.Name}");
            Console.WriteLine($"Length: {info.Length} bytes");
        }
    }
}
