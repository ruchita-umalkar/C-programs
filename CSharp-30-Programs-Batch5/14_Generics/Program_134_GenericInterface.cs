// ============================================
// Program #134 — GenericInterface
// Category  : 14_Generics
// Difficulty: Intermediate
// Description: Implement a generic interface for repository behavior
// ============================================

using System;

namespace CSharp30Programs.Generics
{
    class Program_134_GenericInterface
    {
        static void Main(string[] args)
        {
            IStore<string> store = new TextStore();
            store.Save("Generics are powerful.");
            Console.WriteLine($"Stored value: {store.Get()}");
        }


        interface IStore<T>
        {
            void Save(T value);
            T Get();
        }

        class TextStore : IStore<string>
        {
            private string _value = string.Empty;

            public void Save(string value)
            {
                _value = value;
            }

            public string Get()
            {
                return _value;
            }
        }
    }
}
