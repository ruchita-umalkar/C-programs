// ============================================
// Program #226 — HeapSort
// Category  : 23_Sorting_Algorithms
// Difficulty: Intermediate
// Description: Heap sort using max heap build and extract
// ============================================

using System;

namespace CSharp30Programs.SortingAlgorithms
{
    class Program_226_HeapSort
    {
        static void Main(string[] args)
        {
            int[] arr = { 12, 11, 13, 5, 6, 7 };
            Console.WriteLine("Initial: " + string.Join(", ", arr));

            void Heapify(int[] a, int n, int i)
            {
                int largest = i;
                int left = 2 * i + 1;
                int right = 2 * i + 2;

                if (left < n && a[left] > a[largest]) largest = left;
                if (right < n && a[right] > a[largest]) largest = right;

                if (largest != i)
                {
                    int swap = a[i]; a[i] = a[largest]; a[largest] = swap;
                    Heapify(a, n, largest);
                }
            }

            int n = arr.Length;
            for (int i = n / 2 - 1; i >= 0; i--) Heapify(arr, n, i);
            for (int i = n - 1; i > 0; i--)
            {
                int temp = arr[0]; arr[0] = arr[i]; arr[i] = temp;
                Heapify(arr, i, 0);
            }
            Console.WriteLine("Sorted: " + string.Join(", ", arr));

        }
    }
}
