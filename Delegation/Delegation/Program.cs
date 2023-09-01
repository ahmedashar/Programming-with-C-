using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegation
{
    public delegate void Calculation(int a, int b);

    public delegate void Calculation2(int a);

    public delegate void show();

    class Program
    {
        public static void Display()
        {
            Console.WriteLine("This is a Display Method");
        }
        public static void Square(int number)
        {
            int result = number * number;
            Console.WriteLine("Square: "+ result);

        } 
        public static void Cube(int number)
        {
            int result = number * number * number;
            Console.WriteLine("The Cube of {0} is {1}", number, result);
        }
        public static void Addition(int num1,int num2)
        {
            int result = num1 + num2;
            Console.WriteLine("Addition: " +result);
        } 
        public static void Subtraction(int num1,int num2)
        {
            int result = num1 - num2;
            Console.WriteLine("Subtraction: " +result);
        }  
        public static void Multiply(int num1,int num2)
        {
            int result = num1 * num2;
            Console.WriteLine("Multiply: " +result);
        } 
        public static void Division(int num1,int num2)
        {
            double result = num1 / num2;
            Console.WriteLine("Division: " +result);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("========================");
            Calculation C1 = new Calculation(Program.Multiply);
            C1.Invoke(10, 20);
            Console.WriteLine("========================");
            //C1 = Program.Subtraction; //Re-assign new reference
            //C1.Invoke(10, 20);

            //Calculation C2 = new Calculation(Program.Subtraction);
            //C2.Invoke(20, 10);


            Calculation2 S1 = new Calculation2(Program.Square);
            S1.Invoke(4);
            S1 = Program.Cube;
            S1.Invoke(2);

            //show s1 = new show(Program.Display);
            //s1.Invoke();

            //Calculation C1 = new Calculation(Program.Addition);
            //C1 += Program.Subtraction;
            //C1 -= Program.Multiply;
            //C1 += Program.Division;

            //C1.Invoke(26, 2);
            

            Console.ReadKey();
        }
    }
}

// three types of delegates

//Singlecast delegate point to single method at a time.
//In this the delegate is assigned to a single method at a time.
//They are derived fom System.Delegate class


//Multiple delegates: invoke multiple delegates in a single program.
//Depending on the delegate name or type of paramters passed to the delegate.


//Multi Cast Delegates: When a delegate is wrapped with more than one method
// that is known as a multicast delegate.
//They can point to more than one function at a time.They are derived from
//System.MulicastDelegate class.

//We can use += and -= assignment operators to implement multi cast delegates