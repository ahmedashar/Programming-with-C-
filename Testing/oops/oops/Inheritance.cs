﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    class Vehicle
    {
       protected string name;
        public void getData()
        {
            Console.WriteLine("Vehicle class");
        } 
    }

    class Car: Vehicle
    {

        public void getCarData()
        {

            Console.WriteLine("Car class" + name);
        }
    }
}
