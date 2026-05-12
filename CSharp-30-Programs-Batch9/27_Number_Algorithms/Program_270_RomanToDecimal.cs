// ============================================
// Program #270 — RomanToDecimal
// Category  : 27_Number_Algorithms
// Difficulty: Intermediate
// Description: Convert a Roman numeral string into its decimal value.
// ============================================

using System;
using System.Collections.Generic;

namespace CSharp30Programs.NumberAlgorithms
{
    class Program_270_RomanToDecimal
    {
        static int RomanToInt(string s)
        {
            Dictionary<char, int> map = new Dictionary<char, int>
            {
                ['I'] = 1, ['V'] = 5, ['X'] = 10, ['L'] = 50,
                ['C'] = 100, ['D'] = 500, ['M'] = 1000
            };

            int total = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int value = map[s[i]];
                if (i + 1 < s.Length && value < map[s[i + 1]])
                    total -= value;
                else
                    total += value;
            }
            return total;
        }

        static void Main(string[] args)
        {
            string roman = "MCMXCIV";
            Console.WriteLine($"Roman {roman} = {RomanToInt(roman)}");
        }
    }
}
