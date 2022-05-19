using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenBuilder.Interfaces
{
    public interface IComponentFactory
    {
        public string CreateButton(string content, float height, float width, float top, float left);
        public string CreateTextBox(string content, float height, float width, float top, float left);
    }
}
