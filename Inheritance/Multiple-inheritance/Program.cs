using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevel_inheritance
{
    class Person
    {
        //field
        public string name;

        public Person(string name)
        {
            Console.WriteLine("Person Constructor call" + name);
        }
        //Method
        public void Greet()
        {
            Console.WriteLine("Hello, My name is {0}",this.name);
        }
    }
    class Employee: Person
    {
        public int EmpID;

        public Employee(string name):base(name)
        {
            Console.WriteLine("Employee Constructor is call");
        }

        public void Work()
        {
            Console.WriteLine("Employee Name: {0}, ID: {1}, is Working ",this.name,this.EmpID);
        }
    }
    class Manager : Employee
    {
        public string department;
        public Manager(string name):base(name)
        {

        }
        public void ScheduleMeeting()
        {
            Console.WriteLine("Manager Name: {0}, ID:{1}, Schedulled a meeting for department {2} ", this.name, this.EmpID, this.department);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            //Manager m1 = new Manager();
            //m1.name = "Haseeb";
            //m1.EmpID = 001;
            //m1.department = "Management";

            //m1.Greet();
            //m1.Work();
            //m1.ScheduleMeeting();

            // Person p1 = new Person();
            Employee E1 = new Employee("Ashar");
            Console.ReadKey();
        }
    }
}
