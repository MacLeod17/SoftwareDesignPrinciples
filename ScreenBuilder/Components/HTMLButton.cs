using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScreenBuilder.Interfaces;

namespace ScreenBuilder.Components
{
    public class HTMLButton : IButton
    {
        public string GetCode(string content, float height, float width, float top, float left)
        {
            return $"<button type='button' style='margin-left: {left}; margin-top: {top}; height: {height}; width: {width}'>{content}</button>";
        }
    }
}
