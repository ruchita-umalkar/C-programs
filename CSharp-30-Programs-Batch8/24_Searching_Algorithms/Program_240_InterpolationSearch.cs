// ============================================
// Program #240 — InterpolationSearch
// Category  : 24_Searching_Algorithms
// Difficulty: Intermediate
// Description: Interpolation search for uniformly distributed data
// ============================================

using System;

namespace CSharp30Programs.SearchingAlgorithms
{
    class Program_240_InterpolationSearch
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 20, 30, 40, 50, 60, 70, 80, 90 };
            int target = 70;
            int low = 0, high = arr.Length - 1;

            while (low <= high && target >= arr[low] && target <= arr[high])
            {
                if (low == high)
                {
                    Console.WriteLine(arr[low] == target ? $"Found at index {low}" : "Not found");
                    return;
                }

                int pos = low + (int)((double)(high - low) / (arr[high] - arr[low]) * (target - arr[low]));
                Console.WriteLine($"Probe index {pos}, value {arr[pos]}");

                if (arr[pos] == target)
                {
                    Console.WriteLine($"Found at index {pos}");
                    return;
                }

                if (arr[pos] < target) low = pos + 1;
                else high = pos - 1;
            }

            Console.WriteLine("Not found");

        }
    }
}
