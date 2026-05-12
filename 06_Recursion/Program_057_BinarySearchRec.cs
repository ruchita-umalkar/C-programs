// ============================================
// Program #057 — BinarySearchRec
// Category  : 06_Recursion
// Difficulty: Intermediate
// Description: Binary search implemented recursively
// ============================================

using System;

namespace CSharp30Programs.Recursion
{
    class Program_057_BinarySearchRec
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 5, 8, 12, 16, 23, 38 };
            int target = 16;
            int index = BinarySearch(numbers, target, 0, numbers.Length - 1);

            Console.WriteLine(index >= 0
                ? $"Element {target} found at index {index}."
                : $"Element {target} not found.");
        }

        static int BinarySearch(int[] array, int target, int left, int right)
        {
            if (left > right)
            {
                return -1;
            }

            int mid = left + (right - left) / 2;
            if (array[mid] == target)
            {
                return mid;
            }

            if (array[mid] < target)
            {
                return BinarySearch(array, target, mid + 1, right);
            }

            return BinarySearch(array, target, left, mid - 1);
        }
    }
}
