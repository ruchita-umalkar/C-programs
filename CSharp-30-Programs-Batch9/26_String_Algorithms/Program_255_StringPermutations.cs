// ============================================
// Program #255 — StringPermutations
// Category  : 26_String_Algorithms
// Difficulty: Intermediate
// Description: Generate all permutations of a string recursively.
// ============================================

using System;

namespace CSharp30Programs.StringAlgorithms
{
    class Program_255_StringPermutations
    {
        static void Permute(char[] arr, int l)
        {
            if (l == arr.Length - 1)
            {
                Console.WriteLine(new string(arr));
                return;
            }

            for (int i = l; i < arr.Length; i++)
            {
                (arr[l], arr[i]) = (arr[i], arr[l]);
                Permute(arr, l + 1);
                (arr[l], arr[i]) = (arr[i], arr[l]);
            }
        }

        static void Main(string[] args)
        {
            string input = "ABC";
            Console.WriteLine($"Permutations of {input}:");
            Permute(input.ToCharArray(), 0);
        }
    }
}
