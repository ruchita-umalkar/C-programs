// Program to find gcd and lcm 
using System;
class Program
{
    static void Main()
    {
        int num1 = 12, num2 = 15;

        int gcd = GCD(num1, num2);
        int lcm = LCM(num1, num2);

        Console.WriteLine("GCD: " + gcd);
        Console.WriteLine("LCM: " + lcm);
    }

    static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    static int LCM(int a, int b)
    {
        return (a * b) / GCD(a, b);
    }
}