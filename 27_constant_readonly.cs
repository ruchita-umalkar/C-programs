//Program to demonstrate constants and readonly 
using System;
class Program
{
    static void Main()
    {
        const int a = 10; // Constant
        Console.WriteLine("Value of a: " + a);

        readonly int b = 20; // Readonly field
        Console.WriteLine("Value of b: " + b);
    }
}
