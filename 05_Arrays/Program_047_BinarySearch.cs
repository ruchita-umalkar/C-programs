// ============================================
// Program #047 — BinarySearch
// Category  : 05_Arrays
// Difficulty: Intermediate
// Description: Search element in sorted array using binary search
// ============================================

using System;

namespace CSharp30Programs.Arrays
{
    class Program_047_BinarySearch
    {
        static void Main(string[] args)
        {
            int[] numbers = { 3, 7, 11, 19, 24, 31, 42 };
            int target = 24;
            int left = 0;
            int right = numbers.Length - 1;
            int index = -1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (numbers[mid] == target)
                {
                    index = mid;
                    break;
                }

                if (numbers[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            Console.WriteLine(index >= 0
                ? $"Element {target} found at index {index}."
                : $"Element {target} not found.");
        }
    }
}
