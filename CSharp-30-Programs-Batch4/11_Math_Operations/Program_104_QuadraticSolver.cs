// ============================================
// Program #104 — QuadraticSolver
// Category  : 11_Math_Operations
// Difficulty: Intermediate
// Description: Solve quadratic equation and show roots
// ============================================

using System;

namespace CSharp30Programs.MathOperations
{
    class Program_104_QuadraticSolver
    {
        static void Main(string[] args)
        {
            double a = 1;
            double b = -3;
            double c = 2;
            double discriminant = b * b - 4 * a * c;
            Console.WriteLine($"Equation: {a}x² + {b}x + {c} = 0");
            if (discriminant > 0)
            {
                double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine($"Two Real Roots: {root1} and {root2}");
            }
            else if (discriminant == 0)
            {
                double root = -b / (2 * a);
                Console.WriteLine($"One Real Root: {root}");
            }
            else
            {
                double realPart = -b / (2 * a);
                double imaginaryPart = Math.Sqrt(-discriminant) / (2 * a);
                Console.WriteLine($"Complex Roots: {realPart} + {imaginaryPart}i and {realPart} - {imaginaryPart}i");
            }
        }
    }
}
