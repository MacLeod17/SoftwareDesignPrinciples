using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iterator.Interfaces;
using Iterator.ConcreteIterator;

namespace Iterator.ConcreteAggregate
{
    public class BackpackInventory : IInventoryAggregate
    {
        public List<IItem> inventory;

        public BackpackInventory()
        {
            this.inventory = new List<IItem>();
        }

        public void AddItem(IItem newItem)
        {
            inventory.Add(newItem);
        }

        public IInventoryIterator GetIterator()
        {
            return new BackpackIterator(this);
        }
    }
}
