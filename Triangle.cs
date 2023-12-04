using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5_3._2
{
    public class Triangle : Figure
    {
        private double a;
        private double b;
        private double c;

        public Triangle(string name, double a, double b, double c) : base(name)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public void SetABC(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public (double, double, double) GetABC()
        {
            return (a, b, c);
        }

        public override double Area2
        {
            get { return Area(); }
        }

        public override double Area()
        {
            double s = (a + b + c) / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Sides: {a}, {b}, {c}");
        }
    }
}