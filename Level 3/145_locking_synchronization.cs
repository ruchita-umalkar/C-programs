// Program to demonstrate locking and synchronization 
using System;
using System.Threading;

class Program
{
    private static readonly object lockObject = new object();
    private static int sharedCounter = 0;

    static void Main()
    {
        // Create and start multiple threads
        Thread thread1 = new Thread(IncrementCounter);
        Thread thread2 = new Thread(IncrementCounter);
        Thread thread3 = new Thread(IncrementCounter);

        thread1.Start();
        thread2.Start();
        thread3.Start();

        // Wait for all threads to complete
        thread1.Join();
        thread2.Join();
        thread3.Join();

        Console.WriteLine($"Final counter value: {sharedCounter}");
    }

    static void IncrementCounter()
    {
        for (int i = 0; i < 1000; i++)
        {
            lock (lockObject)
            {
                sharedCounter++;
            }
        }
    }
}
