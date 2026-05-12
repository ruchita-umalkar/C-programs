// ============================================
// Program #203 — ThrowVsRethrow
// Category  : 21_Exception_Handling
// Difficulty: Intermediate
// Description: Compares throw and throw ex stack traces
// ============================================

using System;

namespace CSharp30Programs.ExceptionHandling
{
    class Program_203_ThrowVsRethrow
    {
        static void Main(string[] args)
        {
            TryWithRethrow();
            Console.WriteLine("---");
            TryWithThrowEx();
        }

        static void TryWithRethrow()
        {
            try
            {
                LevelOne();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Rethrow using 'throw':");
                Console.WriteLine(GetTopStack(ex));
            }
        }

        static void TryWithThrowEx()
        {
            try
            {
                LevelOneWithThrowEx();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Rethrow using 'throw ex':");
                Console.WriteLine(GetTopStack(ex));
            }
        }

        static void LevelOne()
        {
            try
            {
                LevelTwo();
            }
            catch
            {
                throw;
            }
        }

        static void LevelOneWithThrowEx()
        {
            try
            {
                LevelTwo();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        static void LevelTwo()
        {
            throw new InvalidOperationException("Sample failure");
        }

        static string GetTopStack(Exception ex)
        {
            var line = ex.StackTrace?.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            return line == null || line.Length == 0 ? "No stack trace" : line[0];
        }
    }
}
