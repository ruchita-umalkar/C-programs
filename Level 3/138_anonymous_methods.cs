// Program to demonstrate anonymous methods 
using System;

class Program
{
    static void Main()
    {
        // Anonymous method
        Func<int, int> square = delegate (int x)
        {
            return x * x;
        };

        Console.WriteLine($"Square of 5: {square(5)}");
    }
}
