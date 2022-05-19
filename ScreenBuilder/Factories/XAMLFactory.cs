using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScreenBuilder.Interfaces;
using ScreenBuilder.Components;

namespace ScreenBuilder.Factories
{
    public class XAMLFactory : IComponentFactory
    {
        public string CreateButton(string content, float height, float width, float top, float left)
        {
            return new XAMLButton().GetCode(content, height, width, top, left);
        }

        public string CreateTextBox(string content, float height, float width, float top, float left)
        {
            return new XAMLTextBox().GetCode(content, height, width, top, left);
        }
    }
}
