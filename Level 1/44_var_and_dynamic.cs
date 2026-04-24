//Program to demonstrate var and dynamic 
using System;
class Program
{
    static void Main()
    {
        var x = 10; // x is inferred as int
        dynamic y = "Hello"; // y can hold any type

        Console.WriteLine("Value of x: " + x);
        Console.WriteLine("Value of y: " + y);

        y = 20; // y can now hold an int
        Console.WriteLine("New value of y: " + y);
    }
}
