using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrafficLight.Interfaces;
using TrafficLight.States;

namespace TrafficLight.Context
{
    public class TrafficLight
    {
        ILightState Light;

        public TrafficLight()
        {
            Light = new GreenState();
        }

        public Color CurrentColor()
        {
            return Light.GetColor();
        }

        public void NewState(Timer timer, TextBox green, TextBox yellow, TextBox red)
        {
            green.BackColor = Color.Gray;
            yellow.BackColor = Color.Gray;
            red.BackColor = Color.Gray;

            timer.Interval = Interval();

            switch (CurrentColor().Name)
            {
                case "Green":
                    green.BackColor = CurrentColor();
                    break;
                case "Yellow":
                    yellow.BackColor = CurrentColor();
                    break;
                case "Red":
                    red.BackColor = CurrentColor();
                    break;
            }
        }

        public void Green()
        {
            this.Light = Light.Green();
        }

        public void Yellow()
        {
            this.Light = Light.Yellow();
        }

        public void Red()
        {
            this.Light = Light.Red();
        }

        public void Next()
        {
            this.Light = Light.Next();
        }

        public int Interval()
        {
            return Light.TimerInterval();
        }
    }
}
