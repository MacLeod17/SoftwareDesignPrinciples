using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileStream.Decorators
{
    public class WriterComponent : TextWriter
    {
        public override Encoding Encoding => throw new NotImplementedException();

        private TextWriter baseWriter;

        public WriterComponent(TextWriter writer)
        {
            baseWriter = writer;
        }

        public override void Write(string value)
        {
            baseWriter.Write(value);
        }

        public override void Close()
        {
            baseWriter.Close();
        }
    }
}
