using System;
using Iterator.Interfaces;
using Iterator.Items;
using Iterator.ConcreteIterator;
using Iterator.ConcreteAggregate;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Concrete Aggregate - Backpack
            IInventoryAggregate backpack = new BackpackInventory();
            backpack.AddItem(new Book("Heir to the Empire"));
            backpack.AddItem(new Book("Hitchhiker's Guide to the Galaxy"));
            backpack.AddItem(new Map());
            backpack.AddItem(new Torch());

            // Create Concrete Aggregate - Hand
            IInventoryAggregate hands = new HandInventory();
            hands.AddItem(new Torch());
            hands.AddItem(new Map());
            hands.AddItem(new Book("Lord of the Flies"));

            // Get Concrete Iterator from Concrete Aggregate - Backpack
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Backpack");
            Console.ForegroundColor = ConsoleColor.White;
            IInventoryIterator backpackIterator = backpack.GetIterator();
            while (backpackIterator.HasNext())
            {
                Console.WriteLine(backpackIterator.Current().Name());
                backpackIterator.Next();
            }
            Console.WriteLine();

            // Get Concrete Iterator from Concrete Aggregate - Hand
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Hands");
            Console.ForegroundColor = ConsoleColor.White;
            IInventoryIterator handIterator = hands.GetIterator();
            while (handIterator.HasNext())
            {
                Console.WriteLine(handIterator.Current().Name());
                handIterator.Next();
            }
            Console.WriteLine();
        }
    }
}
