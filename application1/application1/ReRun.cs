using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application1
{
    class ReRun
    {
        public static void rerunProgram()

        {
            string again;

            do
            {
                Console.Write("Enter First Number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Second Number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                int sum = num1 + num2;

                Console.WriteLine("Sum is : {0}", sum);


                Console.WriteLine("Do you want to ReRun the program? yes/no");

                again = Console.ReadLine();

            } while (again == "yes");
        }
    }
}
