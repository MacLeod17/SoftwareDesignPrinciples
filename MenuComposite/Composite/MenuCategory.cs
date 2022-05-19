using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenuComposite.Interfaces;

namespace MenuComposite.Composite
{
    // Composite Object (has children)
    public class MenuCategory : IMenu
    {
        string name;
        List<IMenu> menuItems;

        public MenuCategory(string name)
        {
            this.name = name;
            this.menuItems = new List<IMenu>();
        }

        public void Add(IMenu menuItem)
        {
            menuItems.Add(menuItem);
        }

        public void GetName()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.WriteLine(this.name);
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var item in menuItems)
            {
                item.GetName();
            }
            Console.WriteLine();
        }

        public void Remove(IMenu menuItem)
        {
            menuItems.Remove(menuItem);
        }
    }
}
