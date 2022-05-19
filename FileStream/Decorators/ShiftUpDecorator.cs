using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileStream.Decorators
{
    public class ShiftUpDecorator : WriterComponent
    {
        public ShiftUpDecorator(TextWriter writer) : base(writer)
        {

        }

        public override void Write(string value)
        {
            char[] s = value.ToCharArray();
            string ret = "";

            for (int i = 0; i < s.Length; i++)
            {
                s[i]++;
                ret += s[i];
            }

            base.Write($"{ret}");
        }
    }
}
