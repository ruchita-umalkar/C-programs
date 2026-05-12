// ============================================
// Program #105 — SimpleInterest
// Category  : 11_Math_Operations
// Difficulty: Basic
// Description: Calculate simple interest for principal, rate, and time
// ============================================

using System;

namespace CSharp30Programs.MathOperations
{
    class Program_105_SimpleInterest
    {
        static void Main(string[] args)
        {
            double principal = 10000;
            double rate = 7.5;
            double time = 3;
            double simpleInterest = (principal * rate * time) / 100;
            Console.WriteLine($"Principal: {principal}");
            Console.WriteLine($"Rate: {rate}%");
            Console.WriteLine($"Time: {time} years");
            Console.WriteLine($"Simple Interest: {simpleInterest}");
        }
    }
}
