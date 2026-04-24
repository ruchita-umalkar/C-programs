// Program to demonstrate Func, Action, Predicate 
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Func delegate - returns a value
        Func<int, int> square = x => x * x;
        Console.WriteLine($"Square of 5: {square(5)}");

        // Action delegate - performs an action (no return value)
        Action<string> printMessage = message => Console.WriteLine(message);
        printMessage("Hello, World!");

        // Predicate delegate - returns a boolean value
        Predicate<int> isEven = x => x % 2 == 0;
        Console.WriteLine($"Is 4 even? {isEven(4)}");
    }
}
