using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace properties
{
    class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Designation { get; set; }

        public void Display()
        {
            Console.WriteLine("Name: {0}\nAge: {1}\nDesignation: {2}",Name,Age,Designation);
        }
    }
}
