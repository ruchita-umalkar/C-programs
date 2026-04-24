// Program to demonstrate destructor 
using System;
class MyClass
{
    private int value;

    // Constructor
    public MyClass(int initialValue)
    {
        value = initialValue;
    }

    // Destructor
    ~MyClass()
    {
        Console.WriteLine("Destructor called for object with value: " + value);
    }

    public void DisplayValue()
    {
        Console.WriteLine("Value: " + value);
    }
}