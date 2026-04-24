//Program to demonstrate Span and ReadOnlySpan 
using System;
class Program
{
    static void Main()
    {
        string str = "Hello, World!";
        Span<char> span = str.ToCharArray();
        ReadOnlySpan<char> readOnlySpan = str.AsSpan();

        Console.WriteLine("Original string: " + str);
        Console.WriteLine("Span: " + new string(span));
        Console.WriteLine("ReadOnlySpan: " + new string(readOnlySpan));
    }
}