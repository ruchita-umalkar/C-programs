// ============================================
// Program #169 — SequentialVsParallelAsync
// Category  : 17_Async_Await
// Difficulty: Intermediate
// Description: Compares sequential and parallel async execution durations
// ============================================

using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace CSharp30Programs.AsyncAwait
{
    class Program_169_SequentialVsParallelAsync
    {
        static async Task Main(string[] args)
        {
            Stopwatch sw = Stopwatch.StartNew();
            await WorkAsync();
            await WorkAsync();
            sw.Stop();
            Console.WriteLine($"Sequential ms: {sw.ElapsedMilliseconds}");

            sw.Restart();
            await Task.WhenAll(WorkAsync(), WorkAsync());
            sw.Stop();
            Console.WriteLine($"Parallel ms: {sw.ElapsedMilliseconds}");
        }

        static async Task WorkAsync()
        {
            await Task.Delay(200);
        }
    }
}
