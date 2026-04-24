//  Program to convert string to uppercase/lowercase
using System;

class Program
{
    static void Main()
    {
        string str = "Hello, World!";
        Console.WriteLine("Original string: " + str);
        Console.WriteLine("Uppercase: " + str.ToUpper());
        Console.WriteLine("Lowercase: " + str.ToLower());
    }
}
