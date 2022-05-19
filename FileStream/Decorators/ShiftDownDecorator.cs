using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileStream.Decorators
{
    public class ShiftDownDecorator : ReaderComponent
    {
        public ShiftDownDecorator(TextReader writer) : base(writer)
        {

        }

        public override string ReadToEnd()
        {
            string output = "";
            char[] ch = base.ReadToEnd().ToCharArray();

            for (int i = 0; i < ch.Length; i++)
            {
                ch[i]--;
                output += ch[i];
            }

            return output;
        }
    }
}
