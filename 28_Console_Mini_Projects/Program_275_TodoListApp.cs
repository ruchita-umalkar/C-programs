// ============================================
// Program #275 — TodoListApp
// Category  : 28_Console_Mini_Projects
// Difficulty: [Intermediate]
// Description: Console todo list with add, remove, complete, and view features.
// ============================================

using System;

namespace CSharp30Programs.ConsoleMiniProjects
{
    class Program_275_TodoListApp
    {
        static void Main(string[] args)
        {
            var tasks = new System.Collections.Generic.List<string>();
            var completed = new System.Collections.Generic.HashSet<int>();
            while (true)
            {
                Console.WriteLine("\n1.Add 2.Remove 3.Complete 4.View 5.Exit");
                Console.Write("Choose: ");
                string choice = (Console.ReadLine() ?? "").Trim();
                if (choice == "1")
                {
                    Console.Write("Task: ");
                    string t = (Console.ReadLine() ?? "").Trim();
                    if (t.Length > 0) tasks.Add(t);
                }
                else if (choice == "2")
                {
                    Show(tasks, completed);
                    Console.Write("Task number to remove: ");
                    if (int.TryParse(Console.ReadLine(), out int idx) && idx >= 1 && idx <= tasks.Count)
                    {
                        tasks.RemoveAt(idx - 1);
                        var next = new System.Collections.Generic.HashSet<int>();
                        foreach (var c in completed) if (c != idx - 1) next.Add(c > idx - 1 ? c - 1 : c);
                        completed = next;
                    }
                }
                else if (choice == "3")
                {
                    Show(tasks, completed);
                    Console.Write("Task number to mark completed: ");
                    if (int.TryParse(Console.ReadLine(), out int idx) && idx >= 1 && idx <= tasks.Count) completed.Add(idx - 1);
                }
                else if (choice == "4") Show(tasks, completed);
                else if (choice == "5") break;
                else Console.WriteLine("Invalid choice.");
            }
            Console.WriteLine("Todo app closed.");
        }

        static void Show(System.Collections.Generic.List<string> tasks, System.Collections.Generic.HashSet<int> completed)
        {
            Console.WriteLine("--- Todo List ---");
            if (tasks.Count == 0) { Console.WriteLine("No tasks."); return; }
            for (int i = 0; i < tasks.Count; i++) Console.WriteLine($"{i + 1}. [{(completed.Contains(i) ? 'X' : ' ')}] {tasks[i]}");
        }
    }
}
