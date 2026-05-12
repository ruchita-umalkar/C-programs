// ============================================
// Program #197 — BuilderPattern
// Category  : 20_Design_Patterns
// Difficulty: Intermediate
// Description: Builds a pizza using a builder pattern
// ============================================

using System;
using System.Collections.Generic;

namespace CSharp30Programs.DesignPatterns
{
    class Pizza
    {
        public string Size { get; set; }
        public string Crust { get; set; }
        public string Sauce { get; set; }
        public List<string> Toppings { get; } = new List<string>();

        public override string ToString()
        {
            return $"Size: {Size}, Crust: {Crust}, Sauce: {Sauce}, Toppings: {string.Join(", ", Toppings)}";
        }
    }

    class PizzaBuilder
    {
        private readonly Pizza _pizza = new Pizza();

        public PizzaBuilder SetSize(string size) { _pizza.Size = size; return this; }
        public PizzaBuilder SetCrust(string crust) { _pizza.Crust = crust; return this; }
        public PizzaBuilder SetSauce(string sauce) { _pizza.Sauce = sauce; return this; }
        public PizzaBuilder AddTopping(string topping) { _pizza.Toppings.Add(topping); return this; }
        public Pizza Build() => _pizza;
    }

    class Program_197_BuilderPattern
    {
        static void Main(string[] args)
        {
            var builder = new PizzaBuilder();
            Pizza pizza = builder
                .SetSize("Large")
                .SetCrust("Thin")
                .SetSauce("Tomato Basil")
                .AddTopping("Mozzarella")
                .AddTopping("Olives")
                .Build();

            Console.WriteLine("Built pizza:");
            Console.WriteLine(pizza);
        }
    }
}
