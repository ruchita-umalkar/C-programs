// Program to demonstrate value vs reference types 
using System;
class Program
{
    static void Main()
    {
        // Value type
        int x = 5;
        int y = x; // y gets a copy of x's value
        x = 10; // Changing x does not affect y
        Console.WriteLine("x: " + x + ", y: " + y);

        // Reference type
        int[] arr1 = { 1, 2, 3 };
        int[] arr2 = arr1; // arr2 references the same array as arr1
        arr1[0] = 5; // Changing arr1 affects arr2
        Console.WriteLine("arr1[0]: " + arr1[0] + ", arr2[0]: " + arr2[0]);
    }
}
