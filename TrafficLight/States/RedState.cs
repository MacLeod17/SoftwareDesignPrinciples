using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrafficLight.Interfaces;

namespace TrafficLight.States
{
    public class RedState : ILightState
    {
        public Color GetColor()
        {
            return Color.Red;
        }

        public ILightState Green()
        {
            return new GreenState();
        }

        public ILightState Next()
        {
            return new GreenState();
        }

        public ILightState Red()
        {
            return new RedState();
        }

        public int TimerInterval()
        {
            return 5000;
        }

        public ILightState Yellow()
        {
            return new RedState();
        }
    }
}
