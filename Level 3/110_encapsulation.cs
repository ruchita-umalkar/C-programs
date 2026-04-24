// Program to demonstrate encapsulation 
using System;
class Person
{
    private string name;
    private int age;

    public Person(string n, int a)
    {
        name = n;
        age = a;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set
        {
            if (value >= 0)
                age = value;
        }
    }
}