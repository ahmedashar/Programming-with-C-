using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application1
{
    class Class2
    {
        public static void multiDArray()
        {                        //[row,col]
            int[,] number = new int[2, 5] { {1,2,3,4,5},{6,7,8,9,10} };

            Console.WriteLine("2D Array Output: "+ number[0, 2]);

            //Console.WriteLine(number[1, 3]);

            // get row length
            Console.WriteLine("Length of row in number: {0}",number.GetLength(0));
            //get col length
            Console.WriteLine("Length of col in number: {0}",number.GetLength(1));

            int rowLength = number.GetLength(0);
            int colLength = number.GetLength(1);


            for(int i= 0; i<rowLength; i++) { 
            
                for(int j=0; j < colLength; j++)
                {
                    Console.WriteLine(number[i,j]);
                }

                Console.WriteLine("-------------------");
            
            }





        }
    }
}
