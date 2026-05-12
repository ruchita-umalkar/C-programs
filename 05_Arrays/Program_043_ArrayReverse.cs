// ============================================
// Program #043 — ArrayReverse
// Category  : 05_Arrays
// Difficulty: Basic
// Description: Reverse an array without using Array.Reverse
// ============================================

using System;

namespace CSharp30Programs.Arrays
{
    class Program_043_ArrayReverse
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            int left = 0;
            int right = numbers.Length - 1;

            while (left < right)
            {
                int temp = numbers[left];
                numbers[left] = numbers[right];
                numbers[right] = temp;
                left++;
                right--;
            }

            Console.WriteLine("Reversed array: " + string.Join(", ", numbers));
        }
    }
}
