// ============================================
// Program #181 — SealedClass
// Category  : 19_Advanced_OOP
// Difficulty: Intermediate
// Description: Demonstrates a sealed class preventing inheritance
// ============================================

using System;

namespace CSharp30Programs.AdvancedOOP
{
    sealed class SealedEngine
    {
        public string Model { get; }

        public SealedEngine(string model)
        {
            Model = model;
        }

        public void Start()
        {
            Console.WriteLine($"Engine {Model} started.");
        }
    }

    class Program_181_SealedClass
    {
        static void Main(string[] args)
        {
            var engine = new SealedEngine("X9");
            engine.Start();
            Console.WriteLine("SealedEngine cannot be inherited by other classes.");
        }
    }
}
