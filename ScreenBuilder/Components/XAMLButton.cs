using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScreenBuilder.Interfaces;

namespace ScreenBuilder.Components
{
    public class XAMLButton : IButton
    {
        public string GetCode(string content, float height, float width, float top, float left)
        {
            return $"<Button Height='{height}' Width='{width}' Margin='{left} {top} 0 0'>{content}</Button>";
        }
    }
}
