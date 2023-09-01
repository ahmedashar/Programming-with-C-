using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic
{
    class Example
    {
        public static void DisplayData2(int a)
        {
            Console.WriteLine(a);
        }
        public static void DisplayData<B>(B a)   // <T> --> placeholder for defining a generic methods
        {
            Console.WriteLine(a);
            
        }

        //public static void PrintArray(int[] arr)
        public static void PrintArray<G>(G[] arr) //generic method
        {
            Console.WriteLine("---------------Print Array--------------");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }


    // generic class
    class Demo <B>
    {
        //public int item;
        private B item;

        public Demo(B a)
        {
            this.item = a;
        }

        // public int Print(){ return this.item; }
        public B Print()
        {
            return this.item;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Example.DisplayData2(2);
           

            Example.DisplayData('a');
            Example.DisplayData("AShar");
            Example.DisplayData(23);
            Example.DisplayData(23.3);
            //int x = 20;
            //string name = "Ashar";
            //double number = 20.2;

            //string[] names = { "Owais", "Talha", "Siraj"};
            //int[] ages = { 22,23,24};

            //Example.DisplayData(x);
            //Example.DisplayData(name);
            //Example.DisplayData(number);

            //Example.PrintArray(names);
            //Example.PrintArray(ages);

            Example E1 = new Example;

            Demo<string> D1 = new Demo<string>("Ashar");

            Demo<int> D2 = new Demo<int>(20);

            Demo<double> D3 = new Demo<double>(12.55);



            Console.WriteLine(D2.Print());

            string x = D1.Print();

            Console.WriteLine(x);
        }
    }
}
