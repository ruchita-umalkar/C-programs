//Program to generate random numbers 
using System;
class Program       
{
    static void Main()
    {
        Random random = new Random();

        Console.WriteLine("Random Number 1: " + random.Next());
        Console.WriteLine("Random Number 2: " + random.Next());
        Console.WriteLine("Random Number 3: " + random.Next());
    }
}
