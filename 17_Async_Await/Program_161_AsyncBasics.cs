// ============================================
// Program #161 — AsyncBasics
// Category  : 17_Async_Await
// Difficulty: Intermediate
// Description: Runs a simple asynchronous method and waits for completion
// ============================================

using System;
using System.Threading.Tasks;

namespace CSharp30Programs.AsyncAwait
{
    class Program_161_AsyncBasics
    {
        static async Task Main(string[] args)
        {
            await SayHelloAsync();
            Console.WriteLine("Main completed.");
        }

        static async Task SayHelloAsync()
        {
            await Task.Delay(200);
            Console.WriteLine("Hello from async method.");
        }
    }
}
