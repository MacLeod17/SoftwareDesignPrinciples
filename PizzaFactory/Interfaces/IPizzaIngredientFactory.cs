using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactory.Interfaces
{
    public interface IPizzaIngredientFactory
    {
        IDough CreateDough();
        ICheese CreateCheese();
        ISauce CreateSauce();
        List<IMeat> CreateMeats();
        List<IVeggie> CreateVeggies();
    }
}
