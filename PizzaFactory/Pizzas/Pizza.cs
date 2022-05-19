using PizzaFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactory.Pizzas
{
    public abstract class Pizza
    {
        public ISauce sauce;
        public List<IVeggie> veggies;
        public ICheese cheese;
        public List<IMeat> meats;
        public IDough dough;

        public string name;

        public abstract void Prepare();

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public List<string> GetIngredients()
        {
            List<string> ingredients = new List<string>();

            if(dough != null)
            {
                ingredients.Add(this.dough.GetName());
            }
            if (sauce != null)
            {
                ingredients.Add(this.sauce.GetName());
            }
            if (cheese != null)
            {
                ingredients.Add(this.cheese.GetName());
            }
            if (meats != null)
            {
                foreach(var meat in meats)
                {
                    ingredients.Add(meat.GetName());
                }
            }
            if (veggies != null)
            {
                foreach (var vegeble in veggies)
                {
                    ingredients.Add(vegeble.GetName());
                }
            }
            return ingredients;
        }
    }
}
