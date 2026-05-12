// ============================================
// Program #230 — TimSort
// Category  : 23_Sorting_Algorithms
// Difficulty: Intermediate
// Description: TimSort combining insertion sort and merge sort
// ============================================

using System;

namespace CSharp30Programs.SortingAlgorithms
{
    class Program_230_TimSort
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 21, 7, 23, 19, 10, 3, 12 };
            const int RUN = 4;
            Console.WriteLine("Initial: " + string.Join(", ", arr));

            void InsertionSort(int left, int right)
            {
                for (int i = left + 1; i <= right; i++)
                {
                    int temp = arr[i];
                    int j = i - 1;
                    while (j >= left && arr[j] > temp)
                    {
                        arr[j + 1] = arr[j];
                        j--;
                    }
                    arr[j + 1] = temp;
                }
            }

            void Merge(int l, int m, int r)
            {
                int len1 = m - l + 1, len2 = r - m;
                int[] left = new int[len1];
                int[] right = new int[len2];
                System.Array.Copy(arr, l, left, 0, len1);
                System.Array.Copy(arr, m + 1, right, 0, len2);

                int i = 0, j = 0, k = l;
                while (i < len1 && j < len2)
                    arr[k++] = left[i] <= right[j] ? left[i++] : right[j++];
                while (i < len1) arr[k++] = left[i++];
                while (j < len2) arr[k++] = right[j++];
            }

            int n = arr.Length;
            for (int i = 0; i < n; i += RUN)
                InsertionSort(i, System.Math.Min(i + RUN - 1, n - 1));

            for (int size = RUN; size < n; size *= 2)
            {
                for (int left = 0; left < n; left += 2 * size)
                {
                    int mid = left + size - 1;
                    int right = System.Math.Min(left + 2 * size - 1, n - 1);
                    if (mid < right) Merge(left, mid, right);
                }
            }

            Console.WriteLine("Sorted: " + string.Join(", ", arr));

        }
    }
}
