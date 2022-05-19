using Iterator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Items
{
    public class Book : IItem
    {
        private string ItemName;

        public Book(string bookName)
        {
            this.ItemName = bookName;
        }

        public string Name()
        {
            return $"{this.ItemName} Book";
        }
    }
}
