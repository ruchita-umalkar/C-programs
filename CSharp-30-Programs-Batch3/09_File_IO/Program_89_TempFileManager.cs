// ============================================
// Program #89 — TempFileManager
// Category  : 09_File_IO
// Difficulty: Basic
// Description: Create and clean up temporary files safely
// ============================================

using System;
using System.IO;

namespace CSharp30Programs._09_File_IO
{
    class Program_89_TempFileManager
    {
        static void Main(string[] args)
        {
            string tempFile = Path.GetTempFileName();
            File.WriteAllText(tempFile, "Temporary content");
            Console.WriteLine($"Temp file: {tempFile}");
            Console.WriteLine($"Exists before delete: {File.Exists(tempFile)}");
            File.Delete(tempFile);
            Console.WriteLine($"Exists after delete: {File.Exists(tempFile)}");
        }
    }
}
