// ============================================
// Program #144 — AnonymousMethods
// Category  : 15_Delegates_Events
// Difficulty: Intermediate
// Description: Use anonymous methods with delegates
// ============================================

using System;

namespace CSharp30Programs.DelegatesEvents
{
    class Program_144_AnonymousMethods
    {
        static void Main(string[] args)
        {
            Transformer makeUpper = delegate (string text)
            {
                return text.ToUpper();
            };

            Console.WriteLine(makeUpper("anonymous methods in c#"));
        }


        delegate string Transformer(string input);
    }
}
