// ============================================
// Program #117 — UserDefinedConversion
// Category  : 12_Type_Conversion
// Difficulty: Intermediate
// Description: Demonstrate custom implicit and explicit conversion operators
// ============================================

using System;

namespace CSharp30Programs.TypeConversion
{
    class Program_117_UserDefinedConversion
    {
        static void Main(string[] args)
        {
            Temperature temp = 30.5;
            double celsius = (double)temp;
            Console.WriteLine($"Implicit conversion from double to Temperature: {temp.Celsius}°C");
            Console.WriteLine($"Explicit conversion from Temperature to double: {celsius}°C");
        }
    }

    class Temperature
    {
        public double Celsius { get; set; }

        public static implicit operator Temperature(double celsius)
        {
            return new Temperature { Celsius = celsius };
        }

        public static explicit operator double(Temperature temp)
        {
            return temp.Celsius;
        }
    }
}
