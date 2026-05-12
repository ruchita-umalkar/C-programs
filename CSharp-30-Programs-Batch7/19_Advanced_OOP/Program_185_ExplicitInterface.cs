// ============================================
// Program #185 — ExplicitInterface
// Category  : 19_Advanced_OOP
// Difficulty: Intermediate
// Description: Demonstrates explicit interface implementation
// ============================================

using System;

namespace CSharp30Programs.AdvancedOOP
{
    interface IReader
    {
        void Display();
    }

    interface IWriter
    {
        void Display();
    }

    class Document : IReader, IWriter
    {
        void IReader.Display() => Console.WriteLine("Reading document content.");
        void IWriter.Display() => Console.WriteLine("Writing document content.");
    }

    class Program_185_ExplicitInterface
    {
        static void Main(string[] args)
        {
            var doc = new Document();

            IReader reader = doc;
            IWriter writer = doc;

            reader.Display();
            writer.Display();
        }
    }
}
