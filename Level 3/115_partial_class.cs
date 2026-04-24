// Program to demonstrate partial class 
using System;
class Program
{
    static void Main()
    {
        PartialClass obj = new PartialClass();
        obj.Display();
    }
}
partial class PartialClass
{
    public void Display()
    {
        Console.WriteLine("This is a partial class.");
    }
}