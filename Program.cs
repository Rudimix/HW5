using System;
using System.Collections.Generic;

namespace HW5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            foreach (var person in people)
            {
                    person.Print();
                Console.WriteLine(person.ToString());

            }
        }
    }
}
