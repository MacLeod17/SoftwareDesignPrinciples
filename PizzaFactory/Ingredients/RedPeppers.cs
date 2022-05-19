using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaFactory.Interfaces;

namespace PizzaFactory.Ingredients
{
    public class RedPeppers : IVeggie
    {
        public string GetName()
        {
            return "Red Peppers";
        }
    }
}
