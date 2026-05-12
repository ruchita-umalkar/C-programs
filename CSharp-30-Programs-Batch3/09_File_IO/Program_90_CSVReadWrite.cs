// ============================================
// Program #90 — CSVReadWrite
// Category  : 09_File_IO
// Difficulty: Intermediate
// Description: Write and read comma-separated values from a file
// ============================================

using System;
using System.IO;

namespace CSharp30Programs._09_File_IO
{
    class Program_90_CSVReadWrite
    {
        static void Main(string[] args)
        {
            string path = Path.Combine(Path.GetTempPath(), "program90.csv");
            var rows = new[]
            {
                "Name,Age,City",
                "Asha,24,Pune",
                "Ravi,28,Mumbai"
            };
            File.WriteAllLines(path, rows);
            var loadedRows = File.ReadAllLines(path);
            foreach (var row in loadedRows)
            {
                var columns = row.Split(',');
                Console.WriteLine(string.Join(" | ", columns));
            }
        }
    }
}
