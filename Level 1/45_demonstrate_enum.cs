//Program to demonstrate enum 
using System;  
class Program  
{  
    enum Days { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };  
  
    static void Main()  
    {  
        Days today = Days.Wednesday;  
        Console.WriteLine("Today is: " + today);  
    }  
}
