using PizzaFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactory.Ingredients
{
    public class Pepperoni : IMeat
    {
        public string GetName()
        {
            return "Pepperoni";
        }
    }
}
