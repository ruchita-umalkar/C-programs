// Program to demonstrate immutability of strings 
using System;
class Program
{
    static void Main()
    {
        string str = "Hello, World!";
        Console.WriteLine("Original string: " + str);

        // Attempting to modify the string
        str = str.Replace("World", "C#");
        Console.WriteLine("Modified string: " + str);
    }
}
