// ============================================
// Program #85 — BinaryWriteRead
// Category  : 09_File_IO
// Difficulty: Intermediate
// Description: Write and read primitive data using binary streams
// ============================================

using System;
using System.IO;

namespace CSharp30Programs._09_File_IO
{
    class Program_85_BinaryWriteRead
    {
        static void Main(string[] args)
        {
            string path = Path.Combine(Path.GetTempPath(), "program85.bin");
            using (var fs = new FileStream(path, FileMode.Create, FileAccess.Write))
            using (var writer = new BinaryWriter(fs))
            {
                writer.Write(123);
                writer.Write(45.67);
            }
            using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            using (var reader = new BinaryReader(fs))
            {
                int first = reader.ReadInt32();
                double second = reader.ReadDouble();
                Console.WriteLine($"Values: {first}, {second}");
            }
        }
    }
}
