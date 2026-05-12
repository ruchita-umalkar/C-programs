// ============================================
// Program #80 — LINQPagination
// Category  : 08_LINQ
// Difficulty: Intermediate
// Description: Use Skip and Take to paginate data
// ============================================

using System;
using System.Linq;

namespace CSharp30Programs._08_LINQ
{
    class Program_80_LINQPagination
    {
        static void Main(string[] args)
        {
            var records = Enumerable.Range(1, 20);
            int page = 2;
            int pageSize = 5;
            var paged = records.Skip((page - 1) * pageSize).Take(pageSize);
            Console.WriteLine($"Page {page}: {string.Join(", ", paged)}");
        }
    }
}
