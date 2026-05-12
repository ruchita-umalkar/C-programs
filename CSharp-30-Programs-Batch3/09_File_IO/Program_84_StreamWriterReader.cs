// ============================================
// Program #84 — StreamWriterReader
// Category  : 09_File_IO
// Difficulty: Intermediate
// Description: Write and read multiple lines using stream classes
// ============================================

using System;
using System.IO;

namespace CSharp30Programs._09_File_IO
{
    class Program_84_StreamWriterReader
    {
        static void Main(string[] args)
        {
            string path = Path.Combine(Path.GetTempPath(), "program84.txt");
            using (var writer = new StreamWriter(path))
            {
                writer.WriteLine("Line 1");
                writer.WriteLine("Line 2");
            }
            using (var reader = new StreamReader(path))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
