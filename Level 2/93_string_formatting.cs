// Program to demonstrate string formatting 
using System;
class Program
{
    static void Main()
    {
        string name = "Alice";
        int age = 30;
        double height = 5.6;

        // Using String.Format
        string message1 = String.Format("Hello, my name is {0} and I am {1} years old.", name, age);
        Console.WriteLine(message1);

        // Using interpolated strings (C# 6.0 and later)
        string message2 = $"Hello, my name is {name} and I am {age} years old.";
        Console.WriteLine(message2);

        // Formatting numbers
        double price = 123.456;
        string formattedPrice = price.ToString("F2"); // Format to 2 decimal places
        Console.WriteLine($"The price is {formattedPrice}");

        // Combining formatting
        string combinedMessage = $"Name: {name}, Age: {age}, Height: {height:F1}";
        Console.WriteLine(combinedMessage);
    }
}
