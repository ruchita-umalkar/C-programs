// ============================================
// Program #194 — DecoratorPattern
// Category  : 20_Design_Patterns
// Difficulty: Intermediate
// Description: Adds coffee features using decorators
// ============================================

using System;

namespace CSharp30Programs.DesignPatterns
{
    interface ICoffee
    {
        string Description { get; }
        decimal Cost();
    }

    class SimpleCoffee : ICoffee
    {
        public string Description => "Simple coffee";
        public decimal Cost() => 2.50m;
    }

    abstract class CoffeeDecorator : ICoffee
    {
        protected readonly ICoffee InnerCoffee;

        protected CoffeeDecorator(ICoffee coffee)
        {
            InnerCoffee = coffee;
        }

        public virtual string Description => InnerCoffee.Description;
        public virtual decimal Cost() => InnerCoffee.Cost();
    }

    class MilkDecorator : CoffeeDecorator
    {
        public MilkDecorator(ICoffee coffee) : base(coffee) { }
        public override string Description => InnerCoffee.Description + ", milk";
        public override decimal Cost() => InnerCoffee.Cost() + 0.75m;
    }

    class SugarDecorator : CoffeeDecorator
    {
        public SugarDecorator(ICoffee coffee) : base(coffee) { }
        public override string Description => InnerCoffee.Description + ", sugar";
        public override decimal Cost() => InnerCoffee.Cost() + 0.25m;
    }

    class Program_194_DecoratorPattern
    {
        static void Main(string[] args)
        {
            ICoffee coffee = new SimpleCoffee();
            coffee = new MilkDecorator(coffee);
            coffee = new SugarDecorator(coffee);

            Console.WriteLine(coffee.Description);
            Console.WriteLine($"Total cost: {coffee.Cost():C}");
        }
    }
}
