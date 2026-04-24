// Program to demonstrate extension methods 
using System;
using System.Collections.Generic;
using System.Linq;

public static class StringExtensions
{
    public static bool IsPalindrome(this string str)
    {
        var cleaned = new string(str.Where(c => char.IsLetterOrDigit(c)).Select(char.ToLower).ToArray());
        var reversed = new string(cleaned.Reverse().ToArray());
        return cleaned == reversed;
    }
}

class Program
{
    static void Main()
    {
        string testString = "A man a plan a canal Panama";
        Console.WriteLine($"Is '{testString}' a palindrome? {testString.IsPalindrome()}");
    }
}
