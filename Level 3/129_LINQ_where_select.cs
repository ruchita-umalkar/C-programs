// Program to demonstrate LINQ (Where, Select) 
using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        List<string> list = new List<string>();
        list.Add("Apple");
        list.Add("Banana");
        list.Add("Cherry");

        // Using Where to filter items
        var filteredItems = list.Where(item => item.StartsWith("A"));

        Console.WriteLine("Filtered items:");
        foreach (string item in filteredItems)
        {
            Console.WriteLine(item);
        }

        // Using Select to transform items
        var transformedItems = list.Select(item => item.ToUpper());

        Console.WriteLine("Transformed items:");
        foreach (string item in transformedItems)
        {
            Console.WriteLine(item);
        }
    }
}
