using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ages = new int[5];
            ages[0] = 12;


            // we need to import system.collections namespace
            // Array List
            ArrayList studentInfo = new ArrayList();
            ArrayList employeeInfo = new ArrayList();
            employeeInfo.Add("Owais");
            employeeInfo.Add(25000.5);
            employeeInfo.Add(true);
            employeeInfo.Add(false);
            employeeInfo.Add("Owais");
            employeeInfo.Add(25000.5);
            employeeInfo.Add(true);
            employeeInfo.Add(false);
            employeeInfo.Insert(0, "Ahmed");

            
            
            //ArrayList myList = new ArrayList();
            studentInfo.Add("Owais");
            studentInfo.Add(23);
            studentInfo.Add(true);
            studentInfo.Add('A');
            studentInfo.Add(23.5);

           
            Console.WriteLine("++++++++++++++++++++++++++++++");
            //foreach (object obj in studentInfo)
            //{
            //    Console.WriteLine(obj);
            //} 
            foreach (object obj in employeeInfo)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("Capacity: "+ employeeInfo.Capacity);
            Console.WriteLine("Count: "+ employeeInfo.Count);
            Console.WriteLine("++++++++++++++++++++++++++++++");

            //methods 
            // Add(value), Insert(index,value), Remove(value), RemoveAt(index), Capacity

            //studentInfo.Remove("Owais");
            studentInfo.Insert(1, "Ahmed");
            
            Console.WriteLine("Capacity: "+ studentInfo.Capacity);
            Console.WriteLine("Count: "+ studentInfo.Count);

         
            foreach (object obj in studentInfo)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("===================HASH TABLE=====================");

            Hashtable studentInfo2 = new Hashtable();
            // assign Value -- mehtod 1
            studentInfo2.Add("Id", 102);
            studentInfo2.Add("Name", "Owais");
            studentInfo2.Add("Age", 21);
            studentInfo2.Add("Salary", 50000.500);

            // assign Value -- mehtod 2
            Hashtable employeeDetail = new Hashtable()
            {
                { "id", 102 },{"name","Taha"},{"age", 12.6},{"salary",25000.50}
            };
            Console.WriteLine("===============Employee Detail Hash Table ");
            foreach (object key in employeeDetail.Keys)
            {
                Console.WriteLine(employeeDetail[key]);
            }
            Console.WriteLine("===============Employee Detail Hash Table ");

            Console.WriteLine(studentInfo2["Id"]);


            Console.WriteLine(studentInfo2.Keys);

          
            //hashtable
            foreach (object key in studentInfo2.Keys)
            {
                //Console.WriteLine(key);
                Console.WriteLine("The key is: {0}, and the value is: {1}",key,studentInfo2[key]);
            }
            //Console.WriteLine(myList{1]);
            //Console.WriteLine(myList[2]);
            //Console.WriteLine(myList[3]);



        }
    }
}
