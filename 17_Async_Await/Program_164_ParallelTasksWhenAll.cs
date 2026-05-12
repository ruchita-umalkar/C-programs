// ============================================
// Program #164 — ParallelTasksWhenAll
// Category  : 17_Async_Await
// Difficulty: Intermediate
// Description: Executes multiple tasks in parallel using Task.WhenAll
// ============================================

using System;
using System.Threading.Tasks;

namespace CSharp30Programs.AsyncAwait
{
    class Program_164_ParallelTasksWhenAll
    {
        static async Task Main(string[] args)
        {
            Task<int> t1 = GetValueAfterDelayAsync(2, 200);
            Task<int> t2 = GetValueAfterDelayAsync(4, 300);
            Task<int> t3 = GetValueAfterDelayAsync(6, 100);

            int[] values = await Task.WhenAll(t1, t2, t3);
            Console.WriteLine("Values: " + string.Join(", ", values));
        }

        static async Task<int> GetValueAfterDelayAsync(int value, int delay)
        {
            await Task.Delay(delay);
            return value;
        }
    }
}
