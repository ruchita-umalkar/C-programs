// ============================================
// Program #233 — BinarySearchRecursive
// Category  : 24_Searching_Algorithms
// Difficulty: Intermediate
// Description: Binary search recursive with call trace
// ============================================

using System;

namespace CSharp30Programs.SearchingAlgorithms
{
    class Program_233_BinarySearchRecursive
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 6, 9, 12, 15, 18, 21 };
            int target = 15;

            int Search(int left, int right)
            {
                Console.WriteLine($"Call: left={left}, right={right}");
                if (left > right) return -1;

                int mid = left + (right - left) / 2;
                if (arr[mid] == target) return mid;
                if (arr[mid] < target) return Search(mid + 1, right);
                return Search(left, mid - 1);
            }

            int index = Search(0, arr.Length - 1);
            Console.WriteLine(index >= 0 ? $"Found {target} at index {index}" : "Not found");

        }
    }
}
