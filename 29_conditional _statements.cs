// Program to demonstrate conditional statements 
using System;
class Program   
{
    static void Main()
    {
        int number = 10;

        // If statement
        if (number > 0)
        {
            Console.WriteLine("The number is positive.");
        }

        // If-else statement
        if (number % 2 == 0)
        {
            Console.WriteLine("The number is even.");
        }
        else
        {
            Console.WriteLine("The number is odd.");
        }

        // If-else-if statement
        if (number > 0)
        {
            Console.WriteLine("The number is positive.");
        }
        else if (number < 0)
        {
            Console.WriteLine("The number is negative.");
        }
        else
        {
            Console.WriteLine("The number is zero.");
        }
    }
}
