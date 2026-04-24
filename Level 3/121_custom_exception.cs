// Program to create custom exception 
using System;
class CustomException : Exception
{
    public CustomException(string message) : base(message)
    {
    }
}
class Program
{
    static void Main()
    {
        try
        {
            throw new CustomException("This is a custom exception.");
        }
        catch (CustomException ex)
        {
            Console.WriteLine($"Custom exception caught: {ex.Message}");
        }
    }
}
