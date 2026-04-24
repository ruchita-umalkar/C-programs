//  Program to demonstrate LINQ (Aggregate) 
using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

        // Using Aggregate to compute the sum
        int sum = numbers.Aggregate((acc, x) => acc + x);

        Console.WriteLine($"Sum: {sum}");

        // Using Aggregate with an initial value
        int product = numbers.Aggregate(1, (acc, x) => acc * x);

        Console.WriteLine($"Product: {product}");
    }
}
