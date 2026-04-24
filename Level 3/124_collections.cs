// Program to demonstrate collections (ArrayList) 
using System;
using System.Collections;
class Program
{
    static void Main()
    {
        ArrayList list = new ArrayList();
        list.Add("Apple");
        list.Add("Banana");
        list.Add("Cherry");

        foreach (string item in list)
        {
            Console.WriteLine(item);
        }
    }
}
