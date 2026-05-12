// ============================================
// Program #189 — IDisposableDemo
// Category  : 19_Advanced_OOP
// Difficulty: Intermediate
// Description: Uses IDisposable pattern with a using block
// ============================================

using System;

namespace CSharp30Programs.AdvancedOOP
{
    class FileResource : IDisposable
    {
        private bool _disposed;

        public void Write(string text)
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(FileResource));
            }
            Console.WriteLine($"Writing: {text}");
        }

        public void Dispose()
        {
            if (_disposed)
            {
                return;
            }

            Console.WriteLine("Releasing unmanaged resource.");
            _disposed = true;
        }
    }

    class Program_189_IDisposableDemo
    {
        static void Main(string[] args)
        {
            using (var resource = new FileResource())
            {
                resource.Write("Report.txt");
            }

            Console.WriteLine("Resource disposed via using statement.");
        }
    }
}
