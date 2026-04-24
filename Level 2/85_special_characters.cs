// Program to remove special characters from string
using System;
using System.Text;

class Program
{
    static void Main()
    {
        string str = "Hello, World! How are you?";
        string result = RemoveSpecialCharacters(str);
        Console.WriteLine("Original string: " + str);
        Console.WriteLine("String without special characters: " + result);
    }

    static string RemoveSpecialCharacters(string input)
    {
        StringBuilder sb = new StringBuilder();
        foreach (char c in input)
        {
            if (char.IsLetterOrDigit(c))
            {
                sb.Append(c);
            }
        }
        return sb.ToString();
    }
}
