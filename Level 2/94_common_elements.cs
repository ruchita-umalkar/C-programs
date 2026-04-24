// Program to find common elements in two arrays
using System;
using System.Linq;
class Program
{
    static void Main()
    {
        int[] array1 = { 1, 2, 3, 4, 5 };
        int[] array2 = { 4, 5, 6, 7, 8 };

        var commonElements = array1.Intersect(array2);

        Console.WriteLine("Common elements:");
        foreach (int element in commonElements)
        {
            Console.Write(element + " ");
        }
    }
}
