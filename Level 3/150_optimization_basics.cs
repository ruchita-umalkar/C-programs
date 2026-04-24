// Program to demonstrate performance optimization basics 
using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        // Example of using Stopwatch for performance measurement
        Stopwatch stopwatch = Stopwatch.StartNew();

        // Simulate some work
        for (int i = 0; i < 1000000; i++)
        {
            // Some operation
        }

        stopwatch.Stop();
        Console.WriteLine($"Time taken: {stopwatch.ElapsedMilliseconds} ms");
    }
}
