// Program to demonstrate LINQ (GroupBy) 
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
        list.Add("Avocado");
        list.Add("Blueberry");

        // Using GroupBy to group items
        var groupedItems = list.GroupBy(item => item[0]);

        Console.WriteLine("Grouped items:");
        foreach (var group in groupedItems)
        {
            Console.WriteLine($"Group {group.Key}:");
            foreach (string item in group)
            {
                Console.WriteLine($"  {item}");
            }
        }
    }
}
