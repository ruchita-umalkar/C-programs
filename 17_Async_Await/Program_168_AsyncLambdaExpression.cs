// ============================================
// Program #168 — AsyncLambdaExpression
// Category  : 17_Async_Await
// Difficulty: Intermediate
// Description: Uses an async lambda expression with Func<Task>
// ============================================

using System;
using System.Threading.Tasks;

namespace CSharp30Programs.AsyncAwait
{
    class Program_168_AsyncLambdaExpression
    {
        static async Task Main(string[] args)
        {
            Func<Task> showTimeAsync = async () =>
            {
                await Task.Delay(100);
                Console.WriteLine($"Current second: {DateTime.Now.Second}");
            };

            await showTimeAsync();
        }
    }
}
