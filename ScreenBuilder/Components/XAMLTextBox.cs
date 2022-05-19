using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScreenBuilder.Interfaces;

namespace ScreenBuilder.Components
{
    public class XAMLTextBox : ITextBox
    {
        public string GetCode(string content, float height, float width, float top, float left)
        {
            return $"<TextBox Height='{height}' Width='{width}' Margin='{left} {top} 0 0'>{content}</TextBox>";
        }
    }
}
