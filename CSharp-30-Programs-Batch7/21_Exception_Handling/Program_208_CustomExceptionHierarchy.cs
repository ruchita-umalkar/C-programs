// ============================================
// Program #208 — CustomExceptionHierarchy
// Category  : 21_Exception_Handling
// Difficulty: Intermediate
// Description: Uses a custom exception hierarchy with specific handling
// ============================================

using System;

namespace CSharp30Programs.ExceptionHandling
{
    class AppException : Exception
    {
        public AppException(string message) : base(message) { }
    }

    class DatabaseException : AppException
    {
        public DatabaseException(string message) : base(message) { }
    }

    class NetworkException : AppException
    {
        public NetworkException(string message) : base(message) { }
    }

    class Program_208_CustomExceptionHierarchy
    {
        static void Main(string[] args)
        {
            try
            {
                ThrowDatabase();
            }
            catch (DatabaseException ex)
            {
                Console.WriteLine($"Database handled: {ex.Message}");
            }

            try
            {
                ThrowNetwork();
            }
            catch (AppException ex)
            {
                Console.WriteLine($"App handled: {ex.Message}");
            }
        }

        static void ThrowDatabase() => throw new DatabaseException("Connection timed out.");
        static void ThrowNetwork() => throw new NetworkException("Packet loss detected.");
    }
}
