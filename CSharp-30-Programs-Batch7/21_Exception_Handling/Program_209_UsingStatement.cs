// ============================================
// Program #209 — UsingStatement
// Category  : 21_Exception_Handling
// Difficulty: Intermediate
// Description: Compares using statement and using declaration
// ============================================

using System;

namespace CSharp30Programs.ExceptionHandling
{
    class DemoResource : IDisposable
    {
        private readonly string _name;

        public DemoResource(string name)
        {
            _name = name;
            Console.WriteLine($"Resource {_name} acquired.");
        }

        public void Use() => Console.WriteLine($"Resource {_name} in use.");

        public void Dispose()
        {
            Console.WriteLine($"Resource {_name} disposed.");
        }
    }

    class Program_209_UsingStatement
    {
        static void Main(string[] args)
        {
            using (var resource = new DemoResource("statement"))
            {
                resource.Use();
            }

            using var resource2 = new DemoResource("declaration");
            resource2.Use();
            Console.WriteLine("End of scope will dispose resource2.");
        }
    }
}
