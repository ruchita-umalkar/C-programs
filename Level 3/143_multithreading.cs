// Program to demonstrate multithreading
using System;
using System.Threading;

class Program
{
    static void Main()
    {
        // Create and start multiple threads
        Thread thread1 = new Thread(DoWork);
        Thread thread2 = new Thread(DoWork);
        Thread thread3 = new Thread(DoWork);

        thread1.Start();
        thread2.Start();
        thread3.Start();

        // Wait for all threads to complete
        thread1.Join();
        thread2.Join();
        thread3.Join();
    }

    static void DoWork()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId}: {i}");
            Thread.Sleep(1000); // Simulate some work
        }
    }
}
