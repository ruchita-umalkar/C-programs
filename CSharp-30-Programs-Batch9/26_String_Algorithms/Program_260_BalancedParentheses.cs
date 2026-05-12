// ============================================
// Program #260 — BalancedParentheses
// Category  : 26_String_Algorithms
// Difficulty: Intermediate
// Description: Check whether parentheses are balanced using stack logic.
// ============================================

using System;
using System.Collections.Generic;

namespace CSharp30Programs.StringAlgorithms
{
    class Program_260_BalancedParentheses
    {
        static bool IsBalanced(string s)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char c in s)
            {
                if (c == '(' || c == '{' || c == '[') stack.Push(c);
                else if (c == ')' || c == '}' || c == ']')
                {
                    if (stack.Count == 0) return false;
                    char top = stack.Pop();
                    if ((c == ')' && top != '(') ||
                        (c == '}' && top != '{') ||
                        (c == ']' && top != '['))
                        return false;
                }
            }
            return stack.Count == 0;
        }

        static void Main(string[] args)
        {
            string expr = "{[(a+b)*(c+d)]}";
            Console.WriteLine($"Expression: {expr}");
            Console.WriteLine($"Balanced: {IsBalanced(expr)}");
        }
    }
}
