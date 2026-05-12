// ============================================
// Program #224 — MergeSort
// Category  : 23_Sorting_Algorithms
// Difficulty: Intermediate
// Description: Merge sort with divide and conquer recursion
// ============================================

using System;

namespace CSharp30Programs.SortingAlgorithms
{
    class Program_224_MergeSort
    {
        static void Main(string[] args)
        {
            int[] arr = { 38, 27, 43, 3, 9, 82, 10 };
            Console.WriteLine("Initial: " + string.Join(", ", arr));

            void MergeSort(int[] a, int left, int right)
            {
                if (left >= right) return;
                int mid = left + (right - left) / 2;
                MergeSort(a, left, mid);
                MergeSort(a, mid + 1, right);
                Merge(a, left, mid, right);
            }

            void Merge(int[] a, int left, int mid, int right)
            {
                int n1 = mid - left + 1;
                int n2 = right - mid;
                int[] L = new int[n1];
                int[] R = new int[n2];
                System.Array.Copy(a, left, L, 0, n1);
                System.Array.Copy(a, mid + 1, R, 0, n2);

                int i = 0, j = 0, k = left;
                while (i < n1 && j < n2)
                    a[k++] = L[i] <= R[j] ? L[i++] : R[j++];
                while (i < n1) a[k++] = L[i++];
                while (j < n2) a[k++] = R[j++];
            }

            MergeSort(arr, 0, arr.Length - 1);
            Console.WriteLine("Sorted: " + string.Join(", ", arr));

        }
    }
}
