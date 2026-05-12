// ============================================
// Program #17 — Interface
// Category  : 02_OOP
// Difficulty: Intermediate
// Description: Process payments using an interface implementation
// ============================================

using System;

namespace CSharp30Programs.OOP
{
    interface IPayment
    {
        void ProcessPayment(decimal amount);
    }

    class CreditCard : IPayment
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing credit card payment of {amount:C}.");
        }
    }

    class PayPal : IPayment
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing PayPal payment of {amount:C}.");
        }
    }

    class Program_17_Interface
    {
        static void Main(string[] args)
        {
            IPayment cardPayment = new CreditCard();
            IPayment paypalPayment = new PayPal();

            cardPayment.ProcessPayment(50);
            paypalPayment.ProcessPayment(75);
        }
    }
}
