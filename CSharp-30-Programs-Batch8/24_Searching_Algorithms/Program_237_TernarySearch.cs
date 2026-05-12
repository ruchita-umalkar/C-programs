// ============================================
// Program #237 — TernarySearch
// Category  : 24_Searching_Algorithms
// Difficulty: Intermediate
// Description: Ternary search dividing array into three parts
// ============================================

using System;

namespace CSharp30Programs.SearchingAlgorithms
{
    class Program_237_TernarySearch
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 4, 7, 10, 13, 16, 19, 22, 25 };
            int target = 19;

            int Ternary(int left, int right)
            {
                while (left <= right)
                {
                    int third = (right - left) / 3;
                    int mid1 = left + third;
                    int mid2 = right - third;

                    Console.WriteLine($"left={left}, mid1={mid1}, mid2={mid2}, right={right}");

                    if (arr[mid1] == target) return mid1;
                    if (arr[mid2] == target) return mid2;

                    if (target < arr[mid1]) right = mid1 - 1;
                    else if (target > arr[mid2]) left = mid2 + 1;
                    else
                    {
                        left = mid1 + 1;
                        right = mid2 - 1;
                    }
                }
                return -1;
            }

            int index = Ternary(0, arr.Length - 1);
            Console.WriteLine(index >= 0 ? $"Found at index {index}" : "Not found");

        }
    }
}
