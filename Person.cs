using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public virtual void Print()
        {
            Console.WriteLine("Name: 0, Age: 1", Name, Age);
        }
        public override string ToString()
        {
            return string.Format("Name: 0, Age: 1", Name, Age);
        }
    }
}
