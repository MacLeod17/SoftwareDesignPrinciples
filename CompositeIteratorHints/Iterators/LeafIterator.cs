using CompositeIteratorHints.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeIteratorHints.Iterators
{
    public class LeafIterator : IIterator
    {
        public IComponent GetNext()
        {
            return null;
        }

        public bool HasNext()
        {
            return false;
        }
    }
}
