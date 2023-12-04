using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    class Teacher : Person
    {
        public List<Student> Students { get; set; }

    public override void Print()
        {
            Console.WriteLine("Name: 0, Age: 1", Name, Age);
            foreach (var student in Students)
            {
                Console.WriteLine("Student: 0", student.Name);
            }
        }

    public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Name: 0, Age: 1", Name, Age);
            foreach (var student in Students)
            {
                sb.AppendFormat("Student: 0", student.Name);
            }
        
            return sb.ToString();
        }
    }
}
