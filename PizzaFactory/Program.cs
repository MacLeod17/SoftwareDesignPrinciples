using PizzaFactory.Pizzas;
using PizzaFactory.Stores;
using System;
using System.Collections.Generic;

namespace PizzaFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pizza> orderedPizzas = new List<Pizza>();

            PizzaStore chicagoStore = new ChicagoPizzaStore();
            orderedPizzas.Add(chicagoStore.OrderPizza("cheese"));
            orderedPizzas.Add(chicagoStore.OrderPizza("veggie"));

            foreach(var pizza in orderedPizzas)
            {
                PrintPizza(pizza);
            }

            Console.ReadLine();
        }

        static void PrintPizza(Pizza orderedPizza)
        {
            Console.WriteLine(orderedPizza.GetName());
            Console.WriteLine("---Ingredients---");
            foreach(var ingredient in orderedPizza.GetIngredients())
            {
                Console.WriteLine(ingredient);
            }
            Console.WriteLine(" ");
            Console.WriteLine(" ");
        }
    }
}
