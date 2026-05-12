// ============================================
// Program #225 — QuickSort
// Category  : 23_Sorting_Algorithms
// Difficulty: Intermediate
// Description: Quick sort with pivot and partition logic
// ============================================

using System;

namespace CSharp30Programs.SortingAlgorithms
{
    class Program_225_QuickSort
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 7, 8, 9, 1, 5 };
            Console.WriteLine("Initial: " + string.Join(", ", arr));

            void QuickSort(int[] a, int low, int high)
            {
                if (low < high)
                {
                    int pi = Partition(a, low, high);
                    QuickSort(a, low, pi - 1);
                    QuickSort(a, pi + 1, high);
                }
            }

            int Partition(int[] a, int low, int high)
            {
                int pivot = a[high];
                int i = low - 1;
                for (int j = low; j < high; j++)
                {
                    if (a[j] <= pivot)
                    {
                        i++;
                        int t = a[i]; a[i] = a[j]; a[j] = t;
                    }
                }
                int temp = a[i + 1]; a[i + 1] = a[high]; a[high] = temp;
                return i + 1;
            }

            QuickSort(arr, 0, arr.Length - 1);
            Console.WriteLine("Sorted: " + string.Join(", ", arr));

        }
    }
}
