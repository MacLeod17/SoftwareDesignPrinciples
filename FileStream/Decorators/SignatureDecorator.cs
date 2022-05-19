using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileStream.Decorators
{
    public class SignatureDecorator : WriterComponent
    {
        public SignatureDecorator(TextWriter writer) : base(writer)
        {

        }

        public override void Write(string value)
        {
            base.Write($"{value}\n -Garrick Kilpack, {DateTime.Now}");
        }
    }
}
