//  Program to demonstrate method overriding 
using System;
class BaseClass
{
    public virtual void Display()
    {
        Console.WriteLine("This is the base class method.");
    }
}
class DerivedClass : BaseClass
{
    public override void Display()
    {
        Console.WriteLine("This is the derived class method.");
    }
}