// ============================================
// Program #167 — AsyncFileReadSimulation
// Category  : 17_Async_Await
// Difficulty: Intermediate
// Description: Simulates asynchronous file reading and displays content
// ============================================

using System;
using System.Threading.Tasks;

namespace CSharp30Programs.AsyncAwait
{
    class Program_167_AsyncFileReadSimulation
    {
        static async Task Main(string[] args)
        {
            string content = await ReadFileAsync();
            Console.WriteLine($"Read content: {content}");
        }

        static async Task<string> ReadFileAsync()
        {
            await Task.Delay(150);
            return "Sample file content";
        }
    }
}
