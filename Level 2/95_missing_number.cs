// Program to find missing number in array
using System;
using System.Linq;
class Program
{
    static void Main()
    {
        int[] array = { 1, 2, 3, 5, 6, 7, 8 };
        int n = array.Length + 1; // Since one number is missing
        int total = n * (n + 1) / 2; // Sum of first n natural numbers
        int sum = array.Sum();
        int missingNumber = total - sum;
        Console.WriteLine("The missing number is: " + missingNumber);
    }
}
