using System;

// Indexers: Special members of a class that
// allows an object to be accessed like an array.

namespace Indexers
{
    class Person
    {
        private int[,] numbers = new int[2, 3];

        //              P1[0,0]
        public int this[int row, int col]
        {
            set { numbers[row, col] = value; }
            get { return numbers[row, col]; }
        }

    }
    class Empolyee
    {
       private int id;

       private int[] enrollment = new int[5];

        // E1[0];
        public int this[int index]
        {
            set { enrollment[index] = value; }
            get { return enrollment[index]; }
        }
      
        public int Id
        {
            set { id = value; }
            get { return id; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Empolyee E2 = new Empolyee();
            //E2[0] = 101;
            //E2[1] = 102;
            //E2[2] = 103;
            //E2[3] = 104;
            //E2[4] = 105;

            //for(int i = 0; i<5; i++)
            //{
            //    Console.WriteLine("Enrollments: {0}", E2[i]);
            //}



            //E2.Id = 101;
            //Console.WriteLine(E2.Id);

            Person P1 = new Person();
            P1[0, 0] = 1;
            P1[0, 1] = 2;
            P1[0, 2] = 3;
            P1[1, 0] = 4;
            P1[1, 1] = 5;
            P1[1, 2] = 6;

         
            for(int  i=0; i<2; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write(P1[i,j] + " ");
                }
                Console.WriteLine();

            }

            Console.ReadKey();
        }
    }
}
