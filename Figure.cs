﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5_3._2
{
    public abstract class Figure
    {
        private string name;

        public Figure(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public abstract double Area2 { get; }

        public abstract double Area();

        public virtual void Print()
        {
            Console.WriteLine($"Figure: {name}");
        }
    }
}