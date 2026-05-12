// ============================================
// Program #040 — StringBuilderDemo
// Category  : 04_Strings
// Difficulty: Basic
// Description: Build a large string efficiently using StringBuilder
// ============================================

using System;

namespace CSharp30Programs.Strings
{
    class Program_040_StringBuilderDemo
    {
        static void Main(string[] args)
        {
            var builder = new System.Text.StringBuilder();

            for (int i = 1; i <= 5; i++)
            {
                builder.AppendLine($"Line {i}: This is generated using StringBuilder.");
            }

            Console.WriteLine("Generated text:");
            Console.WriteLine(builder.ToString());
        }
    }
}
