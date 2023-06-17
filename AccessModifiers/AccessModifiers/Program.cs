using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class BankAccount
    {
        //fields (private)
        private string accountNumber;
        private string password;
        private double balance;

        // constructor (Parameterized)
        public BankAccount(string accountNumber, string password)
        {
            this.accountNumber = accountNumber;
            this.password = password;
            this.balance = 0;
        }

        public double Deposit(double amount)
        {

            //this.balance = this.balance + amount;
            this.balance += amount;

            return this.balance;
        }
        public void WithDraw(double amount) {
            if (amount <= this.balance)
            {
                this.balance -= amount;

                Console.WriteLine("WithDraw Successfull");

            }
            else
            {
                Console.WriteLine("Insufficiant Balance");
            }
        }

        public void AccountInfo(string password)
        {
            if (password == this.password)
            {
                Console.WriteLine("=========================");
                Console.WriteLine("Account Number : {0}\nYour Balance: {1}",
                this.accountNumber, this.balance);
                Console.WriteLine("=========================");
            }
            else
            {
                Console.WriteLine("Invalid Password");
            }
        }

    }


    class Program
    {
        static void Main(string[] args)
        {

            BankAccount cust1 = new BankAccount("PK001","aptech123");
           

            Console.WriteLine(cust1.Deposit(500.50));

            cust1.WithDraw(500);

            cust1.AccountInfo("aptech123");

            Console.WriteLine("-----------------------");
            BankAccount cust2 = new BankAccount("PK002", "aaa123");


            cust2.AccountInfo("aaa123");

            cust2.Deposit(1000.50);

            cust2.AccountInfo("aaa123");

            cust2.WithDraw(2000);
            cust2.AccountInfo("aaa123");

            
            
        }
    }
}
