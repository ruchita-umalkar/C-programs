// ============================================
// Program #231 — LinearSearch
// Category  : 24_Searching_Algorithms
// Difficulty: Intermediate
// Description: Linear search with index and step count output
// ============================================

using System;

namespace CSharp30Programs.SearchingAlgorithms
{
    class Program_231_LinearSearch
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 2, 7, 1, 9, 3 };
            int target = 9;
            int steps = 0, index = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                steps++;
                Console.WriteLine($"Step {steps}: check index {i}, value {arr[i]}");
                if (arr[i] == target)
                {
                    index = i;
                    break;
                }
            }

            Console.WriteLine(index >= 0 ? $"Found {target} at index {index} in {steps} steps" : "Not found");

        }
    }
}
