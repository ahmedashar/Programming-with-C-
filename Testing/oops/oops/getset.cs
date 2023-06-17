using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    class Student
    {
        // fields
        private string name;
        private int age;

        //properties
        public string Name
        {
            set { name = value; }
            get { return name; }
        } 
    }
}
