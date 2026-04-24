// Program to demonstrate Dictionary 
using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        Dictionary<string, int> dict = new Dictionary<string, int>();
        dict["Apple"] = 5;
        dict["Banana"] = 10;
        dict["Cherry"] = 15;

        foreach (var kvp in dict)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
    }
}
