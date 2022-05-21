using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficLight.Interfaces
{
    public interface ILightState
    {
        ILightState Red();
        ILightState Yellow();
        ILightState Green();
        ILightState Next();
        Color GetColor();
        int TimerInterval();
    }
}
