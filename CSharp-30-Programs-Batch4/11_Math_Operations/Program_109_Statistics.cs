// ============================================
// Program #109 — Statistics
// Category  : 11_Math_Operations
// Difficulty: Intermediate
// Description: Calculate mean, median, and mode from an array
// ============================================

using System;

namespace CSharp30Programs.MathOperations
{
    class Program_109_Statistics
    {
        static void Main(string[] args)
        {
            double[] numbers = { 2, 4, 4, 5, 7, 9, 4, 10 };
            double sum = 0;
            foreach (double n in numbers)
            {
                sum += n;
            }
            double mean = sum / numbers.Length;
            Array.Sort(numbers);
            double median = numbers.Length % 2 == 0
                ? (numbers[numbers.Length / 2 - 1] + numbers[numbers.Length / 2]) / 2
                : numbers[numbers.Length / 2];
            int mode = 0;
            int maxCount = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[j] == numbers[i])
                    {
                        count++;
                    }
                }
                if (count > maxCount)
                {
                    maxCount = count;
                    mode = (int)numbers[i];
                }
            }
            Console.WriteLine("Numbers: " + string.Join(", ", numbers));
            Console.WriteLine($"Mean: {mean:F2}");
            Console.WriteLine($"Median: {median:F2}");
            Console.WriteLine($"Mode: {mode}");
        }
    }
}
