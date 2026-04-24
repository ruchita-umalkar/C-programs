// Program to demonstrate generic constraints 
using System;

class Program
{
    static void Main()
    {
        // Create instances of the generic class with different types
        Container<int> intContainer = new Container<int>(5);
        Container<string> stringContainer = new Container<string>("Hello, World!");

        // Display the contents of the containers
        Console.WriteLine($"Integer container: {intContainer.Value}");
        Console.WriteLine($"String container: {stringContainer.Value}");
    }
}

// Generic class with a constraint
public class Container<T> where T : class
{
    public T Value { get; }

    public Container(T value)
    {
        Value = value;
    }
}
