// ============================================
// Program #218 — HashTableFromScratch
// Category  : 22_Data_Structures
// Difficulty: Intermediate
// Description: Hash table with chaining for collision handling
// ============================================

using System;

namespace CSharp30Programs.DataStructures
{
    class Program_218_HashTableFromScratch
    {
        static void Main(string[] args)
        {
            int size = 5;
            var table = new System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<int, string>>[size];
            for (int i = 0; i < size; i++) table[i] = new System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<int, string>>();

            int Hash(int key) => key % size;

            void Put(int key, string value)
            {
                int index = Hash(key);
                for (int i = 0; i < table[index].Count; i++)
                {
                    if (table[index][i].Key == key)
                    {
                        table[index][i] = new System.Collections.Generic.KeyValuePair<int, string>(key, value);
                        return;
                    }
                }
                table[index].Add(new System.Collections.Generic.KeyValuePair<int, string>(key, value));
            }

            string Get(int key)
            {
                int index = Hash(key);
                foreach (var pair in table[index])
                {
                    if (pair.Key == key) return pair.Value;
                }
                return "Not found";
            }

            void Display()
            {
                for (int i = 0; i < size; i++)
                {
                    Console.Write($"Bucket {i}: ");
                    foreach (var pair in table[i])
                        Console.Write($"[{pair.Key}:{pair.Value}] ");
                    Console.WriteLine();
                }
            }

            Put(1, "One");
            Put(6, "Six");
            Put(11, "Eleven");
            Put(2, "Two");
            Display();
            Console.WriteLine($"Get key 6: {Get(6)}");

        }
    }
}
