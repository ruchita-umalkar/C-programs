// Program to demonstrate async and await 
using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        // Call the async method and await its result
        string result = await GetMessageAsync();
        Console.WriteLine(result);
    }

    // Async method
    static async Task<string> GetMessageAsync()
    {
        // Simulate an asynchronous operation
        await Task.Delay(1000);
        return "Hello, World!";
    }
}
