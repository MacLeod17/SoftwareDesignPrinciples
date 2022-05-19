using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileStream.Decorators
{
    public class DateDecorator : WriterComponent
    {
        public DateDecorator(TextWriter writer) : base(writer)
        {
            
        }

        public override void Write(string value)
        {
            base.Write($"{value} - {DateTime.Now}");
        }
    }
}
