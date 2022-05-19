using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iterator.Interfaces;
using Iterator.ConcreteAggregate;

namespace Iterator.ConcreteIterator
{
    public class BackpackIterator : IInventoryIterator
    {
        BackpackInventory backpack;
        private int index = 0;

        public BackpackIterator(BackpackInventory inventory)
        {
            this.backpack = inventory;
        }

        public IItem? Current()
        {
            return this.backpack.inventory[this.index] ?? null;
        }

        public bool HasNext()
        {
            return this.index < this.backpack.inventory.Count;
        }

        public void Next()
        {
            this.index++;
        }
    }
}
