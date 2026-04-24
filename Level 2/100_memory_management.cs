//  Program to demonstrate memory management basics 
using System;
class Program
{
    static void Main()
    {
        // Allocating memory for an array
        int[] numbers = new int[5] { 1, 2, 3, 4, 5 };
        Console.WriteLine("Array allocated with values: " + string.Join(", ", numbers));

        // Allocating memory for a string
        string str = "Hello, Memory Management!";
        Console.WriteLine("String allocated: " + str);

        // Forcing garbage collection (not recommended in production code)
        GC.Collect();
        Console.WriteLine("Garbage collection forced.");
    }
}