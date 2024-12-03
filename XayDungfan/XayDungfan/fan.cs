using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XayDungfan
{
    internal class fan
    {
        public const int SLOW = 1;
        public const int MEDIUM = 2;
        public const int HIGH = 3;

        private int speed = SLOW;
        private bool on = false;
        private double radius = 5;
        private string color = "Blue";




        public fan()
        {
        }

        public fan(int _speed, bool _on, double _radius, string _color)
        {
           speed = _speed;
            on = _on;
            radius = _radius;
            color = _color;
        }

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public bool On
        {
            get { return on; } 
            set { on = value; }
        }

        public override string ToString() 
        {
            if(on)
            {
               return $"Fan is on: Speed = {speed}, Color = {color}, Radius = {radius}";
            }
            else
            {
                return $"Fan is off: Color = {color}, Radius = {radius}";
            }
        }

    }
}
