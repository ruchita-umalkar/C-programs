// ============================================
// Program #15 — Encapsulation
// Category  : 02_OOP
// Difficulty: Basic
// Description: Manage a bank account with encapsulated balance
// ============================================

using System;

namespace CSharp30Programs.OOP
{
    class BankAccount
    {
        private decimal balance;

        public decimal Balance
        {
            get { return balance; }
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposit amount must be positive.");
                return;
            }

            balance += amount;
            Console.WriteLine($"Deposited {amount:C}.");
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be positive.");
                return;
            }

            if (amount > balance)
            {
                Console.WriteLine("Insufficient funds.");
                return;
            }

            balance -= amount;
            Console.WriteLine($"Withdrew {amount:C}.");
        }
    }

    class Program_15_Encapsulation
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            account.Deposit(150);
            account.Withdraw(40);
            account.Withdraw(200);

            Console.WriteLine($"Current balance: {account.Balance:C}");
        }
    }
}
