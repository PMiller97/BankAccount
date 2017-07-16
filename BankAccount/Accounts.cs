using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
   abstract class Accounts
    {
        //Fields
        protected double balance;
        protected int number;
        protected string accountType;
        protected int input;

        //Properties
        public double Balance
        {
            get { return this.balance; }
        }

        public int Number
        {
            get { return this.number; }
        }

        public string AccountType
        {
            get { return this.accountType; }
        }

        public int Input
        {
            get { return this.input; }
            set { this.input = value; }
        }

        //Constructor
        public Accounts()
        {
            //this is my default constructor
        }

        public Accounts(double balance, int number, string accountType, int input)
        {
            this.balance = balance;
            this.number = number;
            this.accountType = accountType;
            this.input = input;
        }

        //Method
        public double AccountInfo()
        {
            this.balance = 535.78d;
            this.number = 24681012;
            return balance;
        }

        public int Deposit()
        {
            input = int.Parse(Console.ReadLine());
            balance += input;
            return input;
        }

        public int Withdraw()
        {
            input = int.Parse(Console.ReadLine());
            balance -= input;
            return input;
        }
    }
}
