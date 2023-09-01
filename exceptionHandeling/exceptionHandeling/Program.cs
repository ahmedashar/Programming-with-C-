using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionHandeling
{
    class Program
    {
        static void Main(string[] args)
        {
            //console.write("enter first number: ");
            //int num1 = convert.toint32(console.readline());
            //console.write("enter second number: ");
            //int num2 = convert.toint32(console.readline());

            //try
            //{

            //    int result = num1 / num2;
            //    console.writeline("the output is: " + result);

            //}
            //catch (dividebyzeroexception ex)
            //{
            //    console.writeline("error: " + ex.message);
            //}
            // -------------------------------------------
            //int[] age = new int[3];
            //try
            //{

            //    age[0] = 10;
            //    age[1] = 13;
            //    age[2] = 14;
            //    age[3] = 19;

            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine("Error: " + ex.Message);
            //}
            // ------

            //Console.Write(" Enter Number: ");
            //string number = Console.ReadLine();

            //try
            //{
            //int num = Convert.ToInt32(number);
            //Console.WriteLine("output: "+ num);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Error: "+ ex.Message);  
            //}


            //    Console.Write(" Enter Number: ");
            //    string number = Console.ReadLine();

            //try
            //{
            //    int num = Convert.ToInt32(number);
            //    Console.WriteLine("output: " + num);


            //}
            //catch (DivideByZeroException ex)
            //{

            //    Console.WriteLine("Error1: " + ex.Message);
            //}
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine("Error2: " + ex.Message);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Error3: " + ex.Message);
            //}


            int age = Convert.ToInt32(Console.ReadLine());

            try
            {
                if (age >= 18)
                {
                    Console.WriteLine("Eligible for Voting");
                }
                else
                {
                    throw new Exception("Error: Not Eligible for Voting");
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }





            Console.WriteLine("statement1");
            Console.WriteLine("statement2");
            Console.WriteLine("statement3");
        }
    }
}

// default throw , default catch 
// default throw , our catch
// our throw, default catch
// our thorw, our catch