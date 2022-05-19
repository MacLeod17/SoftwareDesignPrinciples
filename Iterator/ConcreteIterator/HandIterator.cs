using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iterator.Interfaces;
using Iterator.ConcreteAggregate;

namespace Iterator.ConcreteIterator
{
    public class HandIterator : IInventoryIterator
    {
        HandInventory inventory;
        int index = 0; // 0 = right, 1 = left

        public HandIterator(HandInventory inventory)
        {
            this.inventory = inventory;
        }

        public IItem? Current()
        {
            switch (this.index)
            {
                case 0: // Right Hand
                    return inventory.RightHand ?? null;
                case 1: // Left Hand
                    return inventory.LeftHand ?? null;
                default:
                    return null;
            }
        }

        public bool HasNext()
        {
            return this.index == 0 || this.index == 1;
        }

        public void Next()
        {
            this.index++;
        }
    }
}
