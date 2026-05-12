// ============================================
// Program #120 — EnumToInt
// Category  : 12_Type_Conversion
// Difficulty: Intermediate
// Description: Convert enum to int and demonstrate flag enum bitwise operations
// ============================================

using System;

namespace CSharp30Programs.TypeConversion
{
    class Program_120_EnumToInt
    {
        static void Main(string[] args)
        {
            DayOfWeekValue day = DayOfWeekValue.Wednesday;
            int dayNumber = (int)day;
            DayOfWeekValue convertedBack = (DayOfWeekValue)dayNumber;
            Console.WriteLine($"Enum to int: {day} = {dayNumber}");
            Console.WriteLine($"Int to enum: {dayNumber} = {convertedBack}");
            Permissions userPermissions = Permissions.Read | Permissions.Write;
            Console.WriteLine($"Permissions Value: {(int)userPermissions}");
            Console.WriteLine($"Has Read: {userPermissions.HasFlag(Permissions.Read)}");
            Console.WriteLine($"Has Execute: {userPermissions.HasFlag(Permissions.Execute)}");
        }
    }

    enum DayOfWeekValue
    {
        Sunday = 0,
        Monday = 1,
        Tuesday = 2,
        Wednesday = 3,
        Thursday = 4,
        Friday = 5,
        Saturday = 6
    }

    [Flags]
    enum Permissions
    {
        None = 0,
        Read = 1,
        Write = 2,
        Execute = 4
    }
}
