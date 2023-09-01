using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    // created an abstract class by using abstract keyword
   abstract class Animal
    {
        //normal method
        public void Eat()
        {
            Console.WriteLine("Eating");
        }
        
        //abstract method (which did not contain any body)

        public abstract void AnimalSound();
       
    }
    class Dog : Animal {
        public override void AnimalSound()
        {
            Console.WriteLine("Barking");
        }

    }    
    class Cat : Animal {
        public override void AnimalSound()
        {
            Console.WriteLine("Barking");
        }

    }

   sealed class Person
    {
        string name;
    }

   

    class Program
    {
        static void Main(string[] args)
        {
            //Animal cow = new Animal();

            Dog d1 = new Dog();
            d1.AnimalSound();

            Console.ReadKey();


            try {
                
                int age =Convert.ToInt32( Console.ReadLine());
            }
            // catch block runs when error is generated
            catch (Exception ex)
            {
                Console.WriteLine("Error by user : "+ ex);
            }



        }
    }
}
