using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenBuilder.Interfaces
{
    public interface IButton
    {
        public string GetCode(string content, float height, float width, float top, float left);
    }
}
