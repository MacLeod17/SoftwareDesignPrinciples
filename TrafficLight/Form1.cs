using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrafficLight.Context;

namespace TrafficLight
{
    public partial class Form1 : Form
    {
        Context.TrafficLight Light;

        public Form1()
        {
            InitializeComponent();

            Light = new Context.TrafficLight();
            Light.NewState(Timer, Green, Yellow, Red);
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Light.Next();
            Light.NewState(Timer, Green, Yellow, Red);
        }

        private void RedButton_Click(object sender, EventArgs e)
        {
            Light.Red();
            Light.NewState(Timer, Green, Yellow, Red);
        }

        private void YellowButton_Click(object sender, EventArgs e)
        {
            Light.Yellow();
            Light.NewState(Timer, Green, Yellow, Red);
        }

        private void GreenButton_Click(object sender, EventArgs e)
        {
            Light.Green();
            Light.NewState(Timer, Green, Yellow, Red);
        }

        private void Timer_Tick_1(object sender, EventArgs e)
        {
            Light.Next();
            Light.NewState(Timer, Green, Yellow, Red);
        }
    }
}
