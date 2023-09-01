using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace properties
{
  abstract class Person
    {
        public abstract int Id
        {
            set; get;
        }
        public abstract string Name
        {
            set; get;
        }
        public abstract int Age
        {
            get; set;
        }
    }

    class Student : Person
    {
        private string name;
        private int id;
        private int age;

        public override string Name
        {
            get { return name; }
            set { name = value; }

        }

        public override int Id
        {
            get { return id;  }
            set { id = value; }
        }

        public override int Age
        {
            get { return age; }
            set { age = value; }
        }
    }

}

