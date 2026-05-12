// ============================================
// Program #232 — BinarySearch
// Category  : 24_Searching_Algorithms
// Difficulty: Intermediate
// Description: Binary search iterative with mid calculation
// ============================================

using System;

namespace CSharp30Programs.SearchingAlgorithms
{
    class Program_232_BinarySearch
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 5, 8, 12, 16, 23, 38, 56, 72, 91 };
            int target = 23;
            int left = 0, right = arr.Length - 1;
            int result = -1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                Console.WriteLine($"left={left}, right={right}, mid={mid}, value={arr[mid]}");

                if (arr[mid] == target)
                {
                    result = mid;
                    break;
                }
                if (arr[mid] < target) left = mid + 1;
                else right = mid - 1;
            }

            Console.WriteLine(result >= 0 ? $"Found {target} at index {result}" : "Not found");

        }
    }
}
