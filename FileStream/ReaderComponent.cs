using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileStream.Decorators
{
    public class ReaderComponent : TextReader
    {
        private TextReader baseReader;

        public ReaderComponent(TextReader writer)
        {
            baseReader = writer;
        }

        public override string ReadToEnd()
        {
            return baseReader.ReadToEnd();
        }

        public override void Close()
        {
            baseReader.Close();
        }
    }
}
