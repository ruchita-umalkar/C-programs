// Program to demonstrate break and continue 
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Using break:");
        for (int i = 1; i <= 10; i++)
        {
            if (i == 5)
            {
                break; // Exit the loop when i is 5
            }
            Console.WriteLine("Iteration: " + i);
        }

        Console.WriteLine("\nUsing continue:");
        for (int i = 1; i <= 10; i++)
        {
            if (i == 5)
            {
                continue; // Skip the rest of the loop when i is 5
            }
            Console.WriteLine("Iteration: " + i);
        }
    }
}
