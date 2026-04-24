// Program to demonstrate lambda expressions 
using System;
using System.Linq;
class Program
{
    static void Main()
    {
        Func<int, int> square = x => x * x;
        Console.WriteLine($"Square of 5: {square(5)}");

        Func<int, int, int> add = (x, y) => x + y;
        Console.WriteLine($"Sum of 3 and 4: {add(3, 4)}");
    }
}
