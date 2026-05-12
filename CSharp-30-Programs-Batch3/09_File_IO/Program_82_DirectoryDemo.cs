// ============================================
// Program #82 — DirectoryDemo
// Category  : 09_File_IO
// Difficulty: Basic
// Description: Create and inspect a directory
// ============================================

using System;
using System.IO;

namespace CSharp30Programs._09_File_IO
{
    class Program_82_DirectoryDemo
    {
        static void Main(string[] args)
        {
            string dir = Path.Combine(Path.GetTempPath(), "Program82Dir");
            Directory.CreateDirectory(dir);
            bool exists = Directory.Exists(dir);
            Console.WriteLine($"Directory created: {exists}");
            Console.WriteLine($"Path: {dir}");
        }
    }
}
