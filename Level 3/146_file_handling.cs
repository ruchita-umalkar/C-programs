// Program to demonstrate file handling 
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "example.txt";

        // Write to a file
        File.WriteAllText(filePath, "Hello, World!");

        // Read from a file
        string content = File.ReadAllText(filePath);
        Console.WriteLine(content);
    }
}
