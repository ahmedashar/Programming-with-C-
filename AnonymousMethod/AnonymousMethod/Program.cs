using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethod
{
    public delegate void myDelegate(int a);

    public delegate int myDelegate2(int a, int b);

    public delegate int myDelegate3(int a);
    class Program { 

        public static void Square(int number)
        {
        int result = number * number;
        Console.WriteLine("Square: " + result);

         }
        static void Main(string[] args)
        {
            myDelegate D1 = new myDelegate(Program.Square);
            D1(5);

            // anonymous Method
            myDelegate D2 = delegate (int number)
            {
                int square = number * number;
                Console.WriteLine("Square: " + square);

            };
            D2(5);

            myDelegate2 D3 = delegate (int num1, int num2)
            {
                int result = num2 + num1;
                //Console.WriteLine("Addition: "+ result);
                return result;
            };


            // return in anonymous
            int num = D3(5, 10);
            Console.WriteLine(num);


            // lembda expression --> type of anonymous
           // myDelegate3 D4 = (int a) =>
           //{
           //    Console.WriteLine("Output: " + a);
           //};

            //myDelegate3 D5 = (int b) => b * b;


        }
    }
}
