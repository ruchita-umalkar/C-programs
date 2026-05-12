// ============================================
// Program #279 — WordCounterApp
// Category  : 28_Console_Mini_Projects
// Difficulty: [Intermediate]
// Description: Counts words, sentences, and paragraphs from user input text.
// ============================================

using System;

namespace CSharp30Programs.ConsoleMiniProjects
{
    class Program_279_WordCounterApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text (blank line to finish):");
            var lines = new System.Collections.Generic.List<string>();
            while (true)
            {
                string line = Console.ReadLine() ?? "";
                if (line.Length == 0) break;
                lines.Add(line);
            }

            string text = string.Join("\n", lines);
            int words = 0;
            foreach (var part in text.Split(new char[] { ' ', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries)) words++;
            int sentences = 0;
            foreach (char c in text) if (c == '.' || c == '!' || c == '?') sentences++;
            int paragraphs = 0;
            bool inParagraph = false;
            foreach (var line in lines)
            {
                if (line.Trim().Length > 0 && !inParagraph) { paragraphs++; inParagraph = true; }
                if (line.Trim().Length == 0) inParagraph = false;
            }
            if (lines.Count > 0 && paragraphs == 0) paragraphs = 1;

            Console.WriteLine($"Words: {words}");
            Console.WriteLine($"Sentences: {sentences}");
            Console.WriteLine($"Paragraphs: {paragraphs}");
        }
    }
}
