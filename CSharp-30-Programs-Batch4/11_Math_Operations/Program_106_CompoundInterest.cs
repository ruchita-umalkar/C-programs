// ============================================
// Program #106 — CompoundInterest
// Category  : 11_Math_Operations
// Difficulty: Intermediate
// Description: Calculate compound interest with compounding periods
// ============================================

using System;

namespace CSharp30Programs.MathOperations
{
    class Program_106_CompoundInterest
    {
        static void Main(string[] args)
        {
            double principal = 15000;
            double annualRate = 6.5;
            int years = 4;
            int compoundsPerYear = 4;
            double ratePerPeriod = annualRate / 100 / compoundsPerYear;
            int totalPeriods = years * compoundsPerYear;
            double amount = principal * Math.Pow(1 + ratePerPeriod, totalPeriods);
            double compoundInterest = amount - principal;
            Console.WriteLine($"Principal: {principal}");
            Console.WriteLine($"Annual Rate: {annualRate}%");
            Console.WriteLine($"Years: {years}");
            Console.WriteLine($"Compounds/Year: {compoundsPerYear}");
            Console.WriteLine($"Compound Interest: {compoundInterest:F2}");
            Console.WriteLine($"Final Amount: {amount:F2}");
        }
    }
}
