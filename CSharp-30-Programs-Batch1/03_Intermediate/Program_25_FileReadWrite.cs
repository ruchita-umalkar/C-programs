// ============================================
// Program #25 — FileReadWrite
// Category  : 03_Intermediate
// Difficulty: Intermediate
// Description: Write to a file and read the contents back
// ============================================

using System;
using System.IO;

namespace CSharp30Programs.Intermediate
{
    class Program_25_FileReadWrite
    {
        static void Main(string[] args)
        {
            string filePath = Path.Combine(Environment.CurrentDirectory, "sample.txt");
            string content = "File I/O is useful for storing data.";

            try
            {
                File.WriteAllText(filePath, content);
                string readContent = File.ReadAllText(filePath);

                Console.WriteLine($"File path: {filePath}");
                Console.WriteLine($"Read content: {readContent}");

                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                    Console.WriteLine("Temporary file deleted.");
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine($"Access error: {ex.Message}");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"File error: {ex.Message}");
            }
        }
    }
}
