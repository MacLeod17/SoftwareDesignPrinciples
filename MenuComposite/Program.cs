using System;
using MenuComposite.Leaf;
using MenuComposite.Interfaces;
using MenuComposite.Composite;

namespace MenuComposite
{
    class Program
    {
        static void Main(string[] args)
        {
            // Setup Concrete Composites and Leafs
            IMenu bigMenu = new MenuCategory("Menu");
            IMenu menuBurgers = new MenuCategory("Burgers");

            menuBurgers.Add(new MenuItem("Classic Burger", 8f));

            IMenu subCategorySpicy = new MenuCategory("Spicy");
            subCategorySpicy.Add(new MenuItem("Jalapeno Burger", 9f));
            subCategorySpicy.Add(new MenuItem("Chili Burger", 10f));
            subCategorySpicy.Add(new MenuItem("Habanero Burger", 9.5f));

            menuBurgers.Add(subCategorySpicy);
            bigMenu.Add(menuBurgers);

            IMenu menuSoups = new MenuCategory("Soups");
            menuSoups.Add(new MenuItem("Broccoli and Cheese", 7.5f));
            menuSoups.Add(new MenuItem("Chicken Noodle", 8.5f));
            menuSoups.Add(new MenuItem("Tomato Basil", 8f));

            bigMenu.Add(menuSoups);

            bigMenu.GetName();
        }
    }
}
