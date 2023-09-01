using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace properties
{
    // STATIC PROPERTIES
    class University
    {
        private static string universityName;
        private static string departmentName;

        public static string UniversityName
        {
            get { return universityName; }
            set { universityName = value; }
        }

        public static string DepartmentName
        {
            get { return departmentName; }
            set
            { departmentName = value; }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            // // STATIC PROPERTIES (WE CAN DIRECTLY ACCESS BY USING CLASS NAME, WITHOUT CREATING AN INSTANCE )
            //University.UniversityName = "Karachi University";
            //Console.WriteLine(University.UniversityName);


            //University.DepartmentName = "Computer Science";
            //Console.WriteLine(University.DepartmentName);

            // // ABSTRACT PROPERTIES
            //Student s1 = new Student();
            //s1.Name = "Owais";
            //s1.Id = 100;
            //s1.Age = 23;
            //Console.WriteLine(s1.Name);
            //Console.WriteLine(s1.Id);
            //Console.WriteLine(s1.Age);

            // Object Initializer

            Employee E1 = new Employee { 
                Name = "AShar",
                Age = 23,
                Designation = "Faculty"
            };


            E1.Display();

            Console.ReadKey();
        }
    }
}
