using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iterator.Interfaces;
using Iterator.ConcreteIterator;

namespace Iterator.ConcreteAggregate
{
    public class HandInventory : IInventoryAggregate
    {
        public IItem LeftHand { get; private set; }
        public IItem RightHand { get; private set; }

        public HandInventory()
        {

        }

        public void AddItem(IItem newItem)
        {
            if (this.LeftHand == null)
            {
                this.LeftHand = newItem;
            }
            else if (this.RightHand == null)
            {
                this.RightHand = newItem;
            }
            else
            {
                this.LeftHand = this.RightHand;
                this.RightHand = newItem;
            }
        }

        public IInventoryIterator GetIterator()
        {
            return new HandIterator(this);
        }
    }
}
