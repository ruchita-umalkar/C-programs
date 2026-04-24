// Program to demonstrate HashSet 
using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        HashSet<string> set = new HashSet<string>();
        set.Add("Apple");
        set.Add("Banana");
        set.Add("Cherry");

        foreach (string item in set)
        {
            Console.WriteLine(item);
        }
    }
}
