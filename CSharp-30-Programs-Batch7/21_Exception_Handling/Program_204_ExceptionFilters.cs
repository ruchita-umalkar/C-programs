// ============================================
// Program #204 — ExceptionFilters
// Category  : 21_Exception_Handling
// Difficulty: Intermediate
// Description: Uses exception filters with a file size check
// ============================================

using System;
using System.IO;

namespace CSharp30Programs.ExceptionHandling
{
    class Program_204_ExceptionFilters
    {
        static void Main(string[] args)
        {
            long fileSize = 1500;
            long maxSize = 1024;

            try
            {
                if (fileSize > maxSize)
                {
                    throw new IOException("File too large.");
                }

                Console.WriteLine("File processed successfully.");
            }
            catch (IOException ex) when (fileSize > maxSize)
            {
                Console.WriteLine($"Filtered exception: {ex.Message} Size: {fileSize} bytes");
            }
        }
    }
}
