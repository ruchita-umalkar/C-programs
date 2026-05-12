// ============================================
// Program #193 — ObserverPattern
// Category  : 20_Design_Patterns
// Difficulty: Intermediate
// Description: Notifies observers when stock price changes
// ============================================

using System;
using System.Collections.Generic;

namespace CSharp30Programs.DesignPatterns
{
    interface IInvestor
    {
        void Update(string stock, decimal price);
    }

    class Investor : IInvestor
    {
        public string Name { get; }

        public Investor(string name)
        {
            Name = name;
        }

        public void Update(string stock, decimal price)
        {
            Console.WriteLine($"{Name} notified: {stock} is now {price:C}");
        }
    }

    class StockMarket
    {
        private readonly List<IInvestor> _investors = new List<IInvestor>();
        public string StockSymbol { get; }
        private decimal _price;

        public StockMarket(string stockSymbol)
        {
            StockSymbol = stockSymbol;
        }

        public void Register(IInvestor investor) => _investors.Add(investor);
        public void Unregister(IInvestor investor) => _investors.Remove(investor);

        public void SetPrice(decimal price)
        {
            _price = price;
            foreach (var investor in _investors)
            {
                investor.Update(StockSymbol, _price);
            }
        }
    }

    class Program_193_ObserverPattern
    {
        static void Main(string[] args)
        {
            var market = new StockMarket("ACME");
            var alice = new Investor("Alice");
            var bob = new Investor("Bob");

            market.Register(alice);
            market.Register(bob);

            market.SetPrice(120.50m);
            market.SetPrice(128.75m);
        }
    }
}
