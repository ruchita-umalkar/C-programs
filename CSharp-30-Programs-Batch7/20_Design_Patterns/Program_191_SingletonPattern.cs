// ============================================
// Program #191 — SingletonPattern
// Category  : 20_Design_Patterns
// Difficulty: Intermediate
// Description: Implements a singleton database connection
// ============================================

using System;

namespace CSharp30Programs.DesignPatterns
{
    class DatabaseConnection
    {
        private static readonly DatabaseConnection _instance = new DatabaseConnection();
        public string ConnectionId { get; } = Guid.NewGuid().ToString();

        private DatabaseConnection()
        {
        }

        public static DatabaseConnection Instance => _instance;
    }

    class Program_191_SingletonPattern
    {
        static void Main(string[] args)
        {
            var first = DatabaseConnection.Instance;
            var second = DatabaseConnection.Instance;

            Console.WriteLine($"First ID: {first.ConnectionId}");
            Console.WriteLine($"Second ID: {second.ConnectionId}");
            Console.WriteLine($"Same instance: {ReferenceEquals(first, second)}");
        }
    }
}
