using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileStream.Decorators
{
    public class LineEndingDecorator : ReaderComponent
    {
        public LineEndingDecorator(TextReader writer) : base(writer)
        {

        }

        public override string ReadToEnd()
        {
            string output = base.ReadToEnd();
            output = output.Replace("\r\n", "\n");
            return output;
        }
    }
}
