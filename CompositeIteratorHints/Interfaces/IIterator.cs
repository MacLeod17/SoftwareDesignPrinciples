using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeIteratorHints.Interfaces
{
    public interface IIterator
    {
        bool HasNext();
        
        IComponent GetNext();
    }
}
