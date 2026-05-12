// ============================================
// Program #165 — AsyncExceptionHandling
// Category  : 17_Async_Await
// Difficulty: Intermediate
// Description: Handles exceptions thrown from asynchronous methods
// ============================================

using System;
using System.Threading.Tasks;

namespace CSharp30Programs.AsyncAwait
{
    class Program_165_AsyncExceptionHandling
    {
        static async Task Main(string[] args)
        {
            try
            {
                await MightFailAsync(true);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Caught: {ex.Message}");
            }
        }

        static async Task MightFailAsync(bool fail)
        {
            await Task.Delay(100);
            if (fail)
            {
                throw new InvalidOperationException("Simulated async failure.");
            }

            Console.WriteLine("Operation succeeded.");
        }
    }
}
