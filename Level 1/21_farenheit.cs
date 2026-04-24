//  Program to convert Celsius to Fahrenheit
using System;
class Program
{
    static void Main()
    {
        double celsius = 25;
        double fahrenheit = (celsius * 9 / 5) + 32;

        Console.WriteLine(celsius + " °C = " + fahrenheit + " °F");
    }
}