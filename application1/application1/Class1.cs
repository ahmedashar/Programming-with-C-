using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application1
{
    class Class1
    {
        public static void array()
        {
            // array

           // string name = "Ashar";

            string[] studentNames = new string[5] {"Ashar" ,"Owais","Ahmed", "Talha","Zahid"};
                                
            //foreach (string i in studentNames)
            //{
            //    Console.WriteLine(i);
            //}


            int[] ages = new int[] {22,23,24,25,30};



            // first declare then initialize
            double[] salaries = new double[5];

            salaries[0] = 500.25;
            salaries[1] = 500.25;
            salaries[2] = 500.25;
          

            Console.WriteLine(salaries[5]);



            //Console.WriteLine(names[1]);

            //Console.WriteLine("Student Name: {0} and his age is: {1}", names[0],ages[0]);
            //Console.WriteLine("Student Name: {0} and his age is: {1}", names[1],ages[1]);
            //Console.WriteLine("Student Name: {0} and his age is: {1}", names[2],ages[2]);


            //Console.WriteLine(names.Length);
            
            //for(int i=0; i<names.Length; i++)
            //{
            //    Console.WriteLine("Name is {0}, and his age is {1}", names[i], ages[i]);
            //}
      


        }
    }
}
