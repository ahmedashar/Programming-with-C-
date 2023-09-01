using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritance
{
    //class Fly
    //{
    //    public void canFly()
    //    {
    //        Console.WriteLine("Flying");
    //    }
    //}
    //class Swim
    //{
    //    public void canSwim()
    //    {
    //        Console.WriteLine("Swiming");
    //    }
    //}

    // not allowed in c#, we need an interface for this type of scenerio

    interface Fly {
        
        void canFly();
    }
    interface Swim {
        void canSwim();
    }

    class Duck : Fly, Swim
    {
        public void canFly()
        {
            Console.WriteLine("Duck can Fly");
        }  

        public void canSwim()
        {
            Console.WriteLine("Duck can Swim");

        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Duck d1 = new Duck();
            d1.canFly();
            d1.canSwim();
            Console.ReadKey();
        }
    }
}
