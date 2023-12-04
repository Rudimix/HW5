using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5_3._2
{
    public class TriangleColor : Triangle
    {
        private string color;

        public TriangleColor(string name, double a, double b, double c, string color) : base(name, a, b, c)
        {
            this.color = color;
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public override double Area2
        {
            get { return base.Area2; }
        }

        public override double Area()
        {
            return base.Area();
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Color: {color}");
        }
    }
}