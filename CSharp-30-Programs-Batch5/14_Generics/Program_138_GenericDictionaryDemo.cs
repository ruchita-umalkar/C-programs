// ============================================
// Program #138 — GenericDictionaryDemo
// Category  : 14_Generics
// Difficulty: Intermediate
// Description: Use Dictionary<TKey,TValue> with generic key and value types
// ============================================

using System;

namespace CSharp30Programs.Generics
{
    class Program_138_GenericDictionaryDemo
    {
        static void Main(string[] args)
        {
            System.Collections.Generic.Dictionary<int, string> products = new System.Collections.Generic.Dictionary<int, string>
            {
                [1] = "Laptop",
                [2] = "Mouse"
            };

            foreach (var kv in products)
            {
                Console.WriteLine($"Id={kv.Key}, Name={kv.Value}");
            }
        }


    }
}
