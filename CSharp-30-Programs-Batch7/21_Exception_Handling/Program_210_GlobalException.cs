// ============================================
// Program #210 — GlobalException
// Category  : 21_Exception_Handling
// Difficulty: Intermediate
// Description: Registers a global unhandled exception handler
// ============================================

using System;

namespace CSharp30Programs.ExceptionHandling
{
    class Program_210_GlobalException
    {
        static void Main(string[] args)
        {
            AppDomain.CurrentDomain.UnhandledException += (sender, eventArgs) =>
            {
                if (eventArgs.ExceptionObject is Exception ex)
                {
                    Console.WriteLine($"Unhandled exception caught: {ex.Message}");
                }
            };

            Console.WriteLine("Throwing an unhandled exception...");
            throw new InvalidOperationException("Global handler demo");
        }
    }
}
