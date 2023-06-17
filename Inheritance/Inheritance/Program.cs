using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Vehicle //base class (parent)
    {
        public string brand;
        public int model;

        public void EngineStart()
        {
            Console.WriteLine("Engine is Started");
        }
    }
    class Car : Vehicle //derived class (Child)
    {
        public void Drive()
        {


            Console.WriteLine("{0} Car is Driving", this.brand);
        }
    }

    class MotorCycle : Vehicle // derived class (child)
    {
          public void Ride()
        {
            Console.WriteLine("{0} Bike is Riding", this.brand);
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            //Vehicle Civic = new Vehicle();
            Car Civic = new Car();
            Civic.brand = "Civic";
            Civic.EngineStart();
            Civic.Drive();

            MotorCycle CD70 = new MotorCycle();
            CD70.brand = "Unique";

            CD70.EngineStart();
            CD70.Ride();
           
            
        }
    }
}
