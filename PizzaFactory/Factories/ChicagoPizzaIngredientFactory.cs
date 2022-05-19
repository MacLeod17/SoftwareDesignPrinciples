using PizzaFactory.Ingredients;
using PizzaFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactory.Factories
{
    public class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public ICheese CreateCheese()
        {
            return new MozzarellaCheese();
        }

        public IDough CreateDough()
        {
            return new ThickCrustDough();
        }

        public List<IMeat> CreateMeats()
        {
            List<IMeat> meats = new List<IMeat>();
            {
                new Pepperoni();

            }
            return meats;
        }

        public ISauce CreateSauce()
        {
            return new PizzaSauce();
        }

        public List<IVeggie> CreateVeggies()
        {
            List<IVeggie> veggies = new List<IVeggie>();
            {
                new JalapenoPeppers();

            }
            return veggies;
        }
    }
}
