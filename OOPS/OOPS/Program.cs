using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{

    class Student
    {
     //   properties
       public string name;
       public int age;
       public int marks;

    // method
        public void setInfo(string name, int age, int marks)
        {
            this.name = name;
            this.age = age;
            this.marks = marks;

        }

    public void getInfo()
        {
            Console.WriteLine("Student Name is: {0} , Student Age is : {1}," +
                " His Enrollt Number is: {2}",name,age,marks);
        }

        public int numbers(ref int value)
        {

            value = value + 10;

           return value;

        }

        public int sum(int num1)
        {
            int sum = num1 + num1;
            return sum;
        }

        public int sum(int num1 ,double num2)
        {
            int sum = num1;
            return sum;

        }   
        public int sum(int num1, int num2, int num3)
        {
            int sum = num1 + num2 + num3;
            return sum;
        }



    }


    class Program
    {
        static void Main(string[] args)
        {
            //syntax
            //className objectName = new className()

            Student student1 = new Student();  // create an instant (object1)   

            student1.setInfo(name:"haseeb",age: 22,marks: 22);


            int value = 10;

            // call by value : not modify variable value
            // call by reference: modify variable value, use ref keyword


            // Console.WriteLine(student1.numbers(ref value));



            Console.WriteLine(student1.sum(2,2,2));

            Console.WriteLine(value);

        }
    }
}
