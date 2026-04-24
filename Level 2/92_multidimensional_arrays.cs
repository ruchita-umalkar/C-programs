//  Program to demonstrate multidimensional arrays 
using System;
class Program
{
    static void Main()
    {
        int[,] multiArray = new int[3, 4];
        multiArray[0, 0] = 1;
        multiArray[0, 1] = 2;
        multiArray[0, 2] = 3;
        multiArray[0, 3] = 4;
        multiArray[1, 0] = 5;
        multiArray[1, 1] = 6;
        multiArray[1, 2] = 7;
        multiArray[1, 3] = 8;
        multiArray[2, 0] = 9;
        multiArray[2, 1] = 10;
        multiArray[2, 2] = 11;
        multiArray[2, 3] = 12;

        for (int i = 0; i < multiArray.GetLength(0); i++)
        {
            for (int j = 0; j < multiArray.GetLength(1); j++)
            {
                Console.Write(multiArray[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}