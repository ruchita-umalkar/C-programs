// ============================================
// Program #87 — XMLWriteRead
// Category  : 09_File_IO
// Difficulty: Intermediate
// Description: Create and read XML data from a file
// ============================================

using System;
using System.IO;
using System.Xml.Linq;

namespace CSharp30Programs._09_File_IO
{
    class Program_87_XMLWriteRead
    {
        static void Main(string[] args)
        {
            string path = Path.Combine(Path.GetTempPath(), "program87.xml");
            var doc = new XDocument(
                new XElement("Books",
                    new XElement("Book", new XAttribute("Id", 1), new XElement("Title", "C# Basics")),
                    new XElement("Book", new XAttribute("Id", 2), new XElement("Title", "LINQ Guide"))
                )
            );
            doc.Save(path);
            var loaded = XDocument.Load(path);
            foreach (var book in loaded.Root!.Elements("Book"))
            {
                Console.WriteLine($"Book {book.Attribute("Id")?.Value}: {book.Element("Title")?.Value}");
            }
        }
    }
}
