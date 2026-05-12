// ============================================
// Program #198 — AdapterPattern
// Category  : 20_Design_Patterns
// Difficulty: Intermediate
// Description: Adapts an old printer to a new interface
// ============================================

using System;

namespace CSharp30Programs.DesignPatterns
{
    interface INewPrintSystem
    {
        void Print(string text);
    }

    class OldPrinter
    {
        public void PrintOld(string text)
        {
            Console.WriteLine($"[OldPrinter] {text}");
        }
    }

    class OldPrinterAdapter : INewPrintSystem
    {
        private readonly OldPrinter _oldPrinter;

        public OldPrinterAdapter(OldPrinter oldPrinter)
        {
            _oldPrinter = oldPrinter;
        }

        public void Print(string text)
        {
            _oldPrinter.PrintOld(text);
        }
    }

    class Program_198_AdapterPattern
    {
        static void Main(string[] args)
        {
            var oldPrinter = new OldPrinter();
            INewPrintSystem adapter = new OldPrinterAdapter(oldPrinter);

            adapter.Print("Printing through the adapter.");
        }
    }
}
