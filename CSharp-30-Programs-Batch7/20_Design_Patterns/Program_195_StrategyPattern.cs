// ============================================
// Program #195 — StrategyPattern
// Category  : 20_Design_Patterns
// Difficulty: Intermediate
// Description: Uses interchangeable sorting strategies
// ============================================

using System;

namespace CSharp30Programs.DesignPatterns
{
    interface ISortStrategy
    {
        void Sort(int[] data);
    }

    class BubbleSortStrategy : ISortStrategy
    {
        public void Sort(int[] data)
        {
            for (int i = 0; i < data.Length - 1; i++)
            {
                for (int j = 0; j < data.Length - 1 - i; j++)
                {
                    if (data[j] > data[j + 1])
                    {
                        int temp = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = temp;
                    }
                }
            }
        }
    }

    class QuickSortStrategy : ISortStrategy
    {
        public void Sort(int[] data)
        {
            QuickSort(data, 0, data.Length - 1);
        }

        private static void QuickSort(int[] data, int left, int right)
        {
            if (left >= right) return;

            int pivot = data[(left + right) / 2];
            int index = Partition(data, left, right, pivot);
            QuickSort(data, left, index - 1);
            QuickSort(data, index, right);
        }

        private static int Partition(int[] data, int left, int right, int pivot)
        {
            while (left <= right)
            {
                while (data[left] < pivot) left++;
                while (data[right] > pivot) right--;

                if (left <= right)
                {
                    int temp = data[left];
                    data[left] = data[right];
                    data[right] = temp;
                    left++;
                    right--;
                }
            }
            return left;
        }
    }

    class Sorter
    {
        private ISortStrategy _strategy;

        public Sorter(ISortStrategy strategy)
        {
            _strategy = strategy;
        }

        public void SetStrategy(ISortStrategy strategy) => _strategy = strategy;

        public void SortAndPrint(int[] data)
        {
            _strategy.Sort(data);
            Console.WriteLine(string.Join(", ", data));
        }
    }

    class Program_195_StrategyPattern
    {
        static void Main(string[] args)
        {
            int[] data1 = { 9, 4, 1, 6, 2 };
            int[] data2 = (int[])data1.Clone();

            var sorter = new Sorter(new BubbleSortStrategy());
            Console.Write("Bubble sort: ");
            sorter.SortAndPrint(data1);

            sorter.SetStrategy(new QuickSortStrategy());
            Console.Write("Quick sort: ");
            sorter.SortAndPrint(data2);
        }
    }
}
