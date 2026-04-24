// Program to demonstrate virtual and override 
using System;
class Program
{
    static void Main()
    {
        BaseClass obj = new DerivedClass();
        obj.Display();
    }
}
class BaseClass
{
    public virtual void Display()
    {
        Console.WriteLine("This is the base class.");
    }
}
class DerivedClass : BaseClass
{
    public override void Display()
    {
        Console.WriteLine("This is the derived class.");
    }
}