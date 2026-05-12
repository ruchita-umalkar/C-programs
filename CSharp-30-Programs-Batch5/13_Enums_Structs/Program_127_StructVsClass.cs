// ============================================
// Program #127 — StructVsClass
// Category  : 13_Enums_Structs
// Difficulty: Intermediate
// Description: Demonstrate value-type behavior of struct vs class
// ============================================

using System;

namespace CSharp30Programs.EnumsStructs
{
    class Program_127_StructVsClass
    {
        static void Main(string[] args)
        {
            CounterStruct s1 = new CounterStruct { Value = 10 };
            CounterStruct s2 = s1;
            s2.Value = 99;

            CounterClass c1 = new CounterClass { Value = 10 };
            CounterClass c2 = c1;
            c2.Value = 99;

            Console.WriteLine($"Struct values: s1={s1.Value}, s2={s2.Value}");
            Console.WriteLine($"Class values : c1={c1.Value}, c2={c2.Value}");
        }


        struct CounterStruct
        {
            public int Value;
        }

        class CounterClass
        {
            public int Value;
        }
    }
}
