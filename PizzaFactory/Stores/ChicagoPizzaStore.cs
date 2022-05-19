using PizzaFactory.Factories;
using PizzaFactory.Interfaces;
using PizzaFactory.Pizzas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactory.Stores
{
    public class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;

            IPizzaIngredientFactory ingredientFactory = new ChicagoPizzaIngredientFactory();

            switch(type.ToLower())
            {
                case "veggie":
                    pizza = new VeggiePizza(ingredientFactory);
                    pizza.SetName("Chicago Style Veggie Pizza");
                    break;
                case "cheese":
                    pizza = new CheesePizza(ingredientFactory);
                    pizza.SetName("Chicago Style Cheese Pizza");
                    break;

            }

            return pizza;
        }
    }
}
