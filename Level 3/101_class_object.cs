// Program to demonstrate class and object 
using System;
class Program
{
    static void Main()
    {
        // Creating an object of the class
        Student student = new Student();
        student.Name = "Alice";
        student.Age = 20;
        student.DisplayInfo();
    }
}
class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public void DisplayInfo()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
    }
}