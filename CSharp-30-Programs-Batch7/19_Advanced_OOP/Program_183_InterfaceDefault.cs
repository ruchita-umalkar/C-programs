// ============================================
// Program #183 — InterfaceDefault
// Category  : 19_Advanced_OOP
// Difficulty: Intermediate
// Description: Uses a default interface method in C# 8+
// ============================================

using System;

namespace CSharp30Programs.AdvancedOOP
{
    interface IGreeter
    {
        void SayHello()
        {
            Console.WriteLine("Hello from default interface method!");
        }
    }

    class ConsoleGreeter : IGreeter
    {
    }

    class Program_183_InterfaceDefault
    {
        static void Main(string[] args)
        {
            IGreeter greeter = new ConsoleGreeter();
            greeter.SayHello();
        }
    }
}
