// Program to demonstrate Task Parallel Library (TPL) 
using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        // Create and start multiple tasks
        Task task1 = DoWorkAsync("Task 1");
        Task task2 = DoWorkAsync("Task 2");
        Task task3 = DoWorkAsync("Task 3");

        // Wait for all tasks to complete
        await Task.WhenAll(task1, task2, task3);
    }

    static async Task DoWorkAsync(string taskName)
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"{taskName}: {i}");
            await Task.Delay(1000); // Simulate some work
        }
    }
}
