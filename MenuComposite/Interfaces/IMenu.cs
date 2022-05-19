using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuComposite.Interfaces
{
    public interface IMenu
    {
        // Component Interface

        void GetName();

        void Add(IMenu menuItem);

        void Remove(IMenu menuItem);
    }
}
