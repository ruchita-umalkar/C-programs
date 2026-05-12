// ============================================
// Program #206 — OverflowException
// Category  : 21_Exception_Handling
// Difficulty: Intermediate
// Description: Shows unchecked vs checked integer overflow
// ============================================

using System;

namespace CSharp30Programs.ExceptionHandling
{
    class Program_206_OverflowException
    {
        static void Main(string[] args)
        {
            unchecked
            {
                int wrapped = int.MaxValue + 1;
                Console.WriteLine($"Unchecked overflow wraps to: {wrapped}");
            }

            try
            {
                checked
                {
                    int overflowed = int.MaxValue + 1;
                    Console.WriteLine(overflowed);
                }
            }
            catch (OverflowException ex)
            {
                Console.WriteLine($"Checked overflow throws: {ex.Message}");
            }
        }
    }
}
