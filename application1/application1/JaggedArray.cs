using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application1
{
    class JaggedArray
    {
        public static void jagged()
        {
            Console.WriteLine("JAGGED ARRAY");

            // jagged array in C#   
                                                        // 0  1  2       
            string[][] studentNames = new string[3][]; // {  ,  ,  }

            studentNames[0] = new string[3] { "Sabahat", "Haseeb", "Aisha" };
            studentNames[1] = new string[5] { "Aikan", "Maira", "John","Ashar","Owais" };
            studentNames[2] = new string[2] { "Rocky", "BajwaBro"};


           // Console.WriteLine(studentNames[2][1]);

            for(int i = 0; i<studentNames.Length; i++)
            {
                for(int j =0; j<studentNames[i].Length; j++) {

                    Console.Write(studentNames[i][j] + ", "); 
                }

                Console.WriteLine("");

            }

        }
    }
}
