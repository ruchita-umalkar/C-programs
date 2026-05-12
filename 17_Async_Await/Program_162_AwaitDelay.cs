// ============================================
// Program #162 — AwaitDelay
// Category  : 17_Async_Await
// Difficulty: Intermediate
// Description: Demonstrates await with Task.Delay for non-blocking pause
// ============================================

using System;
using System.Threading.Tasks;

namespace CSharp30Programs.AsyncAwait
{
    class Program_162_AwaitDelay
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Starting delay...");
            await Task.Delay(300);
            Console.WriteLine("Delay finished.");
        }
    }
}
