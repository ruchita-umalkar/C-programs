// Program to demonstrate delegates 
using System;
class Program
{
    // Define a delegate
    delegate int IntOp(int x, int y);

    static void Main()
    {
        // Create an instance of the delegate
        IntOp op = Add;

        // Use the delegate
        int result = op(5, 3);
        Console.WriteLine($"Result: {result}");
    }

    // Method that matches the delegate signature
    static int Add(int a, int b)
    {
        return a + b;
    }
}
