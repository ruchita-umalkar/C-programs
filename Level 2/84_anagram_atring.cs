// Program to check anagram strings
using System;
class Program
{
    static void Main()
    {
        string str1 = "listen";
        string str2 = "silent";

        if (IsAnagram(str1, str2))
            Console.WriteLine("Anagram");
        else
            Console.WriteLine("Not Anagram");
    }

    static bool IsAnagram(string s1, string s2)
    {
        char[] arr1 = s1.ToCharArray();
        char[] arr2 = s2.ToCharArray();

        Array.Sort(arr1);
        Array.Sort(arr2);

        return new string(arr1) == new string(arr2);
    }
}   


