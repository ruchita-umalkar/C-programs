// ============================================
// Program #205 — AggregateException
// Category  : 21_Exception_Handling
// Difficulty: Intermediate
// Description: Handles multiple exceptions from parallel tasks
// ============================================

using System;
using System.Threading.Tasks;

namespace CSharp30Programs.ExceptionHandling
{
    class Program_205_AggregateException
    {
        static void Main(string[] args)
        {
            Task[] tasks =
            {
                Task.Run(() => throw new InvalidOperationException("Invalid operation")),
                Task.Run(() => throw new ArgumentException("Bad argument"))
            };

            try
            {
                Task.WaitAll(tasks);
            }
            catch (AggregateException ex)
            {
                foreach (var inner in ex.Flatten().InnerExceptions)
                {
                    Console.WriteLine($"Handled: {inner.GetType().Name} - {inner.Message}");
                }
            }
        }
    }
}
