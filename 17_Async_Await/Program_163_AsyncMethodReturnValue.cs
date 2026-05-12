// ============================================
// Program #163 — AsyncMethodReturnValue
// Category  : 17_Async_Await
// Difficulty: Intermediate
// Description: Returns a value from an asynchronous method using Task<T>
// ============================================

using System;
using System.Threading.Tasks;

namespace CSharp30Programs.AsyncAwait
{
    class Program_163_AsyncMethodReturnValue
    {
        static async Task Main(string[] args)
        {
            int result = await GetSquareAsync(9);
            Console.WriteLine($"Square is {result}");
        }

        static async Task<int> GetSquareAsync(int number)
        {
            await Task.Delay(200);
            return number * number;
        }
    }
}
