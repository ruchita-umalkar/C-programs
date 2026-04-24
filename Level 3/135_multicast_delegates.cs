// Program to demonstrate delegates 
using System;
class Program
{
    // Define a delegate
    delegate void MessageDelegate(string message);

    static void Main()
    {
        // Create an instance of the delegate
        MessageDelegate msgDelegate = PrintMessage;

        // Use the delegate
        msgDelegate("Hello, World!");
    }

    // Method that matches the delegate signature
    static void PrintMessage(string message)
    {
        Console.WriteLine(message);
    }
}
