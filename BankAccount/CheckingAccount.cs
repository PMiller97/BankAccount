using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class CheckingAccount : Accounts
    {
        //Constructor
        public CheckingAccount()
        {
            //this is my default constructor
        }

        public CheckingAccount(double balance, int number, string accountType, int input)
        {
            this.balance = balance;
            this.number = number;
            this.accountType = accountType;
            this.input = input;
        }

        //Method
        public virtual string CheckAccountInfo()
        {
            this.balance = 535.78d;
            this.number = 24681012;
            this.accountType = "Checking";
            return " " + balance;
        }

        public int CheckDeposit()
        {
            input = int.Parse(Console.ReadLine());
            balance += input;
            return input;
        }













    }
}

