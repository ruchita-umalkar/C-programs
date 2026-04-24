// Program to demonstrate reflection 
using System;
using System.Reflection;

class Program
{
    static void Main()
    {
        Type type = typeof(Person);
        Console.WriteLine($"Type: {type.Name}");

        PropertyInfo[] properties = type.GetProperties();
        foreach (PropertyInfo property in properties)
        {
            Console.WriteLine($"Property: {property.Name}, Type: {property.PropertyType}");
        }
    }
}

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}
