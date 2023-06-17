using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    class Program
    {
        static void Main(string[] args)
        {
            //BankAccount cus1 = new BankAccount(2244, "AB123");
            //cus1.deposit(500);
            //cus1.withdraw(600);

            //Console.WriteLine(cus1.checkBalance());
            ////cus1.accountInformation(224);



            Car civic = new Car();
            civic.getData();
            civic.getCarData();
            civic.name = "asdads";
        }
    }
}
