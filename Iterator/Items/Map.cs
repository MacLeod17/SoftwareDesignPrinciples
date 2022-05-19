using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iterator.Interfaces;

namespace Iterator.Items
{
    public class Map : IItem
    {
        public string Name()
        {
            return "Map";
        }
    }
}
