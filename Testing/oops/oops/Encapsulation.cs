using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    class BankAccount
    {
        private int password;
        private string accountNumber;
        private double balance;

        // parameterized constructor
        public BankAccount(int password, string accountNumber)
        {
            this.password = password;
            this.accountNumber = accountNumber;
            this.balance = 0;
        }

        public void deposit(int amount)
        {
            this.balance += amount;
        }

        public void withdraw(int amount)
        {
            if(amount <= this.balance)
            {
                this.balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient funds");
            }
        }

        public double checkBalance()
        {
            return this.balance;
        }

        public void accountInformation(int password)
        {
            if(password == this.password)
            {
                Console.WriteLine("=================================");
                Console.WriteLine("Account Number: {0} \nAccount Balance: {1} \nAccount Password: {2}",this.accountNumber,this.balance,this.password);
                Console.WriteLine("=================================");
            }
            else
            {
                Console.WriteLine("Invalid Password");
            }
        }
    }
}
