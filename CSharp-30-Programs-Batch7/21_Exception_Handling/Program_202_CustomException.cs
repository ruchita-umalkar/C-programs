// ============================================
// Program #202 — CustomException
// Category  : 21_Exception_Handling
// Difficulty: Intermediate
// Description: Throws and catches a custom insufficient funds exception
// ============================================

using System;

namespace CSharp30Programs.ExceptionHandling
{
    class InsufficientFundsException : Exception
    {
        public decimal Amount { get; }

        public InsufficientFundsException(decimal amount)
            : base($"Insufficient funds for withdrawal of {amount:C}.")
        {
            Amount = amount;
        }
    }

    class BankAccount
    {
        public decimal Balance { get; private set; }

        public BankAccount(decimal initialBalance)
        {
            Balance = initialBalance;
        }

        public void Withdraw(decimal amount)
        {
            if (amount > Balance)
            {
                throw new InsufficientFundsException(amount);
            }

            Balance -= amount;
        }
    }

    class Program_202_CustomException
    {
        static void Main(string[] args)
        {
            var account = new BankAccount(150m);

            try
            {
                account.Withdraw(200m);
            }
            catch (InsufficientFundsException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine($"Attempted amount: {ex.Amount:C}");
            }
        }
    }
}
