// ============================================
// Program #271 — ConsoleCalculator
// Category  : 28_Console_Mini_Projects
// Difficulty: [Intermediate]
// Description: Calculator with operations and history log.
// ============================================

using System;

namespace CSharp30Programs.ConsoleMiniProjects
{
    class Program_271_ConsoleCalculator
    {
        static void Main(string[] args)
        {
            var history = new System.Collections.Generic.List<string>();
            Console.WriteLine("Console Calculator");
            while (true)
            {
                Console.WriteLine("\nChoose operation: +  -  *  /  %  | H=History | Q=Quit");
                string op = (Console.ReadLine() ?? "").Trim().ToUpper();
                if (op == "Q") break;
                if (op == "H")
                {
                    Console.WriteLine("--- History ---");
                    if (history.Count == 0) Console.WriteLine("No operations yet.");
                    foreach (var item in history) Console.WriteLine(item);
                    continue;
                }
                if (!(op == "+" || op == "-" || op == "*" || op == "/" || op == "%"))
                {
                    Console.WriteLine("Invalid operation.");
                    continue;
                }

                Console.Write("Enter first number: ");
                if (!double.TryParse(Console.ReadLine(), out double a)) { Console.WriteLine("Invalid number."); continue; }
                Console.Write("Enter second number: ");
                if (!double.TryParse(Console.ReadLine(), out double b)) { Console.WriteLine("Invalid number."); continue; }

                if ((op == "/" || op == "%") && b == 0)
                {
                    Console.WriteLine("Cannot divide by zero.");
                    continue;
                }

                double result = op == "+" ? a + b : op == "-" ? a - b : op == "*" ? a * b : op == "/" ? a / b : a % b;
                string line = $"{a} {op} {b} = {result}";
                history.Add(line);
                Console.WriteLine(line);
            }
            Console.WriteLine("Calculator closed.");
        }
    }
}
