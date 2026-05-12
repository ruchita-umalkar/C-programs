// ============================================
// Program #166 — CancellationTokenDemo
// Category  : 17_Async_Await
// Difficulty: Intermediate
// Description: Cancels an asynchronous operation using CancellationToken
// ============================================

using System;
using System.Threading;
using System.Threading.Tasks;

namespace CSharp30Programs.AsyncAwait
{
    class Program_166_CancellationTokenDemo
    {
        static async Task Main(string[] args)
        {
            using CancellationTokenSource cts = new CancellationTokenSource();
            Task task = CountAsync(cts.Token);

            cts.CancelAfter(250);

            try
            {
                await task;
            }
            catch (OperationCanceledException)
            {
                Console.WriteLine("Operation was cancelled.");
            }
        }

        static async Task CountAsync(CancellationToken token)
        {
            for (int i = 1; i <= 10; i++)
            {
                token.ThrowIfCancellationRequested();
                Console.WriteLine($"Count: {i}");
                await Task.Delay(100, token);
            }
        }
    }
}
