// Program to demonstrate attributes 
using System;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
public class MyAttribute : Attribute
{
    public string Description { get; }

    public MyAttribute(string description)
    {
        Description = description;
    }
}

[My("This is a sample class")]
public class SampleClass
{
    [My("This is a sample method")]
    public void SampleMethod()
    {
        Console.WriteLine("Sample method called.");
    }
}

class Program
{
    static void Main()
    {
        Type type = typeof(SampleClass);
        var attributes = type.GetCustomAttributes(typeof(MyAttribute), false);

        foreach (MyAttribute attr in attributes)
        {
            Console.WriteLine($"Class Attribute: {attr.Description}");
        }

        var method = type.GetMethod("SampleMethod");
        var methodAttributes = method.GetCustomAttributes(typeof(MyAttribute), false);

        foreach (MyAttribute attr in methodAttributes)
        {
            Console.WriteLine($"Method Attribute: {attr.Description}");
        }
    }
}
