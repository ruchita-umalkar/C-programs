// ============================================
// Program #170 — ValueTaskDemo
// Category  : 17_Async_Await
// Difficulty: Intermediate
// Description: Demonstrates a method returning ValueTask for efficiency
// ============================================

using System;
using System.Threading.Tasks;

namespace CSharp30Programs.AsyncAwait
{
    class Program_170_ValueTaskDemo
    {
        static async Task Main(string[] args)
        {
            int value = await GetNumberAsync(true);
            Console.WriteLine($"ValueTask result: {value}");
        }

        static ValueTask<int> GetNumberAsync(bool fastPath)
        {
            if (fastPath)
            {
                return ValueTask.FromResult(42);
            }

            return new ValueTask<int>(Task.Run(async () =>
            {
                await Task.Delay(100);
                return 7;
            }));
        }
    }
}
