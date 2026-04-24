// Program to demonstrate readonly vs const 
using System;
class Program   
{
    static void Main()
    {
        const double PI = 3.14159;
        readonly double radius = 5.0;

        double area = PI * radius * radius;
        Console.WriteLine("Area: " + area);
    }
}