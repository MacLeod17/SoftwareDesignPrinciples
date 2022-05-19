using MenuComposite.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuComposite.Leaf
{
    public class MenuItem : IMenu
    {
        string name;
        float cost;

        public MenuItem(string name, float cost)
        {
            this.name = name;
            this.cost = cost;
        }

        public void Add(IMenu menuItem)
        {
            throw new NotImplementedException();
        }

        public void GetName()
        {
            Console.WriteLine($" - {name} - ${cost:F}");
        }

        public void Remove(IMenu menuItem)
        {
            throw new NotImplementedException();
        }
    }
}
