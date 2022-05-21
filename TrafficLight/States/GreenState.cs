using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrafficLight.Interfaces;

namespace TrafficLight.States
{
    public class GreenState : ILightState
    {
        public Color GetColor()
        {
            return Color.Green;
        }

        public ILightState Green()
        {
            return new GreenState();
        }

        public ILightState Next()
        {
            return new YellowState();
        }

        public ILightState Red()
        {
            return new GreenState();
        }

        public int TimerInterval()
        {
            return 5000;
        }

        public ILightState Yellow()
        {
            return new YellowState();
        }
    }
}
