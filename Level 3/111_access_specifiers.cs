// Program to demonstrate access specifiers 
using System;
class Program
{
    static void Main()
    {
        Person person = new Person("Alice", 30);
        Console.WriteLine("Name: " + person.Name);
        Console.WriteLine("Age: " + person.Age);
    }
}