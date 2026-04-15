// Program to find power of a number 
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter base number: ");
        double baseNum = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter exponent: ");
        double exponent = Convert.ToDouble(Console.ReadLine());

        double result = Math.Pow(baseNum, exponent);

        Console.WriteLine($"{baseNum} raised to the power of {exponent} is: {result}");
    }
}
