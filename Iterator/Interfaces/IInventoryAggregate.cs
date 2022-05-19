using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Interfaces
{
    public interface IInventoryAggregate
    {
        IInventoryIterator GetIterator();

        void AddItem(IItem newItem);
    }
}
