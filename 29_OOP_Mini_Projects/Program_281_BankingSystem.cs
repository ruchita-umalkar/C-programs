// ============================================
// Program #281 — BankingSystem
// Category  : 29_OOP_Mini_Projects
// Difficulty: [Intermediate]
// Description: OOP banking system with account transfer support.
// ============================================

using System;

namespace CSharp30Programs.OOPMiniProjects
{
    class Program_281_BankingSystem
    {
        class Account
        {
            public string Holder { get; }
            public decimal Balance { get; protected set; }
            public Account(string holder, decimal initial) { Holder = holder; Balance = initial; }
            public virtual void Deposit(decimal amount) { if (amount > 0) Balance += amount; }
            public virtual bool Withdraw(decimal amount) { if (amount > 0 && amount <= Balance) { Balance -= amount; return true; } return false; }
            public bool TransferTo(Account target, decimal amount)
            {
                if (Withdraw(amount)) { target.Deposit(amount); return true; }
                return false;
            }
        }

        class SavingsAccount : Account
        {
            public decimal InterestRate { get; }
            public SavingsAccount(string holder, decimal initial, decimal interestRate) : base(holder, initial) { InterestRate = interestRate; }
            public void ApplyInterest() { Balance += Balance * InterestRate; }
        }

        static void Main(string[] args)
        {
            var a1 = new SavingsAccount("Alice", 1000m, 0.02m);
            var a2 = new Account("Bob", 400m);

            a1.Deposit(200m);
            a1.TransferTo(a2, 300m);
            a1.ApplyInterest();

            Console.WriteLine($"{a1.Holder} balance: {a1.Balance:C}");
            Console.WriteLine($"{a2.Holder} balance: {a2.Balance:C}");
        }
    }
}
