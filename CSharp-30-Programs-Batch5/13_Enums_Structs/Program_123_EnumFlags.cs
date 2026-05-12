// ============================================
// Program #123 — EnumFlags
// Category  : 13_Enums_Structs
// Difficulty: Intermediate
// Description: Use Flags enum and combine values with bitwise OR
// ============================================

using System;

namespace CSharp30Programs.EnumsStructs
{
    class Program_123_EnumFlags
    {
        static void Main(string[] args)
        {
            Permissions userPermissions = Permissions.Read | Permissions.Write;
            Console.WriteLine($"Combined permissions: {userPermissions}");
            Console.WriteLine($"Can execute? {userPermissions.HasFlag(Permissions.Execute)}");
        }


        [Flags]
        enum Permissions { None = 0, Read = 1, Write = 2, Execute = 4 }
    }
}
