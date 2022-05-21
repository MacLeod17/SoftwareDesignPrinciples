using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrafficLight.Interfaces;

namespace TrafficLight.States
{
    public class YellowState : ILightState
    {
        public Color GetColor()
        {
            return Color.Yellow;
        }

        public ILightState Green()
        {
            return new YellowState();
        }

        public ILightState Next()
        {
            return new RedState();
        }

        public ILightState Red()
        {
            return new RedState();
        }

        public int TimerInterval()
        {
            return 3000;
        }

        public ILightState Yellow()
        {
            return new YellowState();
        }
    }
}
