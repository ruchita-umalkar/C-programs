// Program to find duplicate elements in array
using System;
using System.Linq;
class Program
{
    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5, 2, 6, 7, 8, 1 };
        var duplicates = array.GroupBy(x => x).Where(g => g.Count() > 1).Select(g => g.Key);
        Console.WriteLine("Duplicate elements:");
        foreach (int element in duplicates)
        {
            Console.Write(element + " ");
        }
    }
}
