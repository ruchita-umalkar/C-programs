//Program to demonstrate jagged arrays
using System;
class Program
{
    static void Main()
    {
        int[][] jaggedArray = new int[3][];
        jaggedArray[0] = new int[] { 1, 2, 3 };
        jaggedArray[1] = new int[] { 4, 5 };
        jaggedArray[2] = new int[] { 6, 7, 8, 9 };

        for (int i = 0; i < jaggedArray.Length; i++)
        {
            Console.WriteLine("Row " + i + ": " + string.Join(", ", jaggedArray[i]));
        }
    }
} 
