// ============================================
// Program #273 — ATMSimulator
// Category  : 28_Console_Mini_Projects
// Difficulty: [Intermediate]
// Description: ATM simulator with PIN, deposit, withdraw, and balance check.
// ============================================

using System;

namespace CSharp30Programs.ConsoleMiniProjects
{
    class Program_273_ATMSimulator
    {
        static void Main(string[] args)
        {
            const string pin = "1234";
            decimal balance = 1000m;
            Console.Write("Enter 4-digit PIN: ");
            if ((Console.ReadLine() ?? "") != pin)
            {
                Console.WriteLine("Invalid PIN. Access denied.");
                return;
            }

            while (true)
            {
                Console.WriteLine("\n1. Balance  2. Deposit  3. Withdraw  4. Exit");
                Console.Write("Choose: ");
                string choice = (Console.ReadLine() ?? "").Trim();
                if (choice == "1") Console.WriteLine($"Current balance: {balance:C}");
                else if (choice == "2")
                {
                    Console.Write("Deposit amount: ");
                    if (decimal.TryParse(Console.ReadLine(), out decimal amount) && amount > 0)
                    {
                        balance += amount;
                        Console.WriteLine("Deposit successful.");
                    }
                    else Console.WriteLine("Invalid amount.");
                }
                else if (choice == "3")
                {
                    Console.Write("Withdraw amount: ");
                    if (decimal.TryParse(Console.ReadLine(), out decimal amount) && amount > 0 && amount <= balance)
                    {
                        balance -= amount;
                        Console.WriteLine("Withdrawal successful.");
                    }
                    else Console.WriteLine("Invalid amount or insufficient balance.");
                }
                else if (choice == "4") break;
                else Console.WriteLine("Invalid choice.");
            }
            Console.WriteLine("Thank you for using the ATM.");
        }
    }
}
