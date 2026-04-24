// Program to demonstrate sealed class 
using System;
class Program
{
    static void Main()
    {
        SealedClass obj = new SealedClass();
        obj.Display();
    }
}
sealed class SealedClass
{
    public void Display()
    {
        Console.WriteLine("This is a sealed class.");
    }
}