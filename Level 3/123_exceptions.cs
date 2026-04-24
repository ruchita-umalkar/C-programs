// Program to demonstrate throwing exceptions 
using System;
class Program
{
    static void Main()
    {
        try
        {
            throw new Exception("This is a thrown exception.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Exception caught: {ex.Message}");
        }
    }
}
