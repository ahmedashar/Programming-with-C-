using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Car
    {
       public string name;
       public int modelNumber;
       public string color;

       public Car(string name, int modelNumber, string color)
        {
            this.name = name;
            this.modelNumber = modelNumber;
            this.color = color;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Civic",2023,"pink");

            Console.WriteLine(car1.name);

        }
    }
}
