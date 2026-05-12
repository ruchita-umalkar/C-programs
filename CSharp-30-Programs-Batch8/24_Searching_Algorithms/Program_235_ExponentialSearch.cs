// ============================================
// Program #235 — ExponentialSearch
// Category  : 24_Searching_Algorithms
// Difficulty: Intermediate
// Description: Exponential search doubling range then binary
// ============================================

using System;

namespace CSharp30Programs.SearchingAlgorithms
{
    class Program_235_ExponentialSearch
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 4, 8, 16, 32, 64, 128, 256 };
            int target = 64;

            int BinarySearch(int left, int right)
            {
                while (left <= right)
                {
                    int mid = left + (right - left) / 2;
                    if (arr[mid] == target) return mid;
                    if (arr[mid] < target) left = mid + 1;
                    else right = mid - 1;
                }
                return -1;
            }

            if (arr[0] == target)
            {
                Console.WriteLine("Found at index 0");
                return;
            }

            int bound = 1;
            while (bound < arr.Length && arr[bound] < target)
            {
                Console.WriteLine($"Expand bound to {bound}");
                bound *= 2;
            }

            int index = BinarySearch(bound / 2, System.Math.Min(bound, arr.Length - 1));
            Console.WriteLine(index >= 0 ? $"Found at index {index}" : "Not found");

        }
    }
}
