// Program to demonstrate collections (List) 
using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        List<string> list = new List<string>();
        list.Add("Apple");
        list.Add("Banana");
        list.Add("Cherry");

        foreach (string item in list)
        {
            Console.WriteLine(item);
        }
    }
}
