using PizzaFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactory.Ingredients
{
    public class PizzaSauce : ISauce
    {
        public string GetName()
        {
            return "Pizza Sauce";
        }
    }
}
