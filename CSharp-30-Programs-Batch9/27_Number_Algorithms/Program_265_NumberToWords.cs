// ============================================
// Program #265 — NumberToWords
// Category  : 27_Number_Algorithms
// Difficulty: Intermediate
// Description: Convert an integer number into English words representation.
// ============================================

using System;

namespace CSharp30Programs.NumberAlgorithms
{
    class Program_265_NumberToWords
    {
        static readonly string[] Ones = { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
        static readonly string[] Tens = { "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

        static string ConvertBelow1000(int n)
        {
            string result = "";
            if (n >= 100)
            {
                result += Ones[n / 100] + " Hundred ";
                n %= 100;
            }
            if (n >= 20)
            {
                result += Tens[n / 10] + " ";
                n %= 10;
            }
            if (n > 0) result += Ones[n] + " ";
            return result.Trim();
        }

        static string NumberToWords(int n)
        {
            if (n == 0) return "Zero";
            if (n < 0) return "Minus " + NumberToWords(-n);

            string[] units = { "", "Thousand", "Million", "Billion" };
            int unitIndex = 0;
            string result = "";

            while (n > 0)
            {
                int chunk = n % 1000;
                if (chunk != 0)
                {
                    string part = ConvertBelow1000(chunk);
                    result = part + (units[unitIndex] == "" ? "" : " " + units[unitIndex]) + (result == "" ? "" : " " + result);
                }
                n /= 1000;
                unitIndex++;
            }
            return result.Trim();
        }

        static void Main(string[] args)
        {
            int num = 1234567;
            Console.WriteLine($"{num} in words: {NumberToWords(num)}");
        }
    }
}
