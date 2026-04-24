// Program to demonstrate generics 
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a list of integers
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

        // Create a list of strings
        List<string> names = new List<string> { "Alice", "Bob", "Charlie" };

        // Display the contents of the lists
        Console.WriteLine("Numbers:");
        foreach (int n in numbers)
        {
            Console.WriteLine(n);
        }

        Console.WriteLine("Names:");
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }
}
