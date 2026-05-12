// ============================================
// Program #201 — TryCatchFinally
// Category  : 21_Exception_Handling
// Difficulty: Intermediate
// Description: Shows try/catch/finally with divide-by-zero
// ============================================

using System;

namespace CSharp30Programs.ExceptionHandling
{
    class Program_201_TryCatchFinally
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Attempting division...");
                int result = 10 / 0;
                Console.WriteLine($"Result: {result}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Caught exception: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Finally block executed for cleanup.");
            }
        }
    }
}
