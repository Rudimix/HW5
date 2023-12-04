using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    class Student : Person
    {
        public string School { get; set; }
        public Teacher Teacher { get; set; }

        public override void Print()
        {
            Console.WriteLine("Name: 0, Age: 1, School: 2", Name, Age, School);
        }

    public override string ToString()
        {
            return string.Format("Name: 0, Age: 1, School: 2", Name, Age, School);
        }
    }
}
