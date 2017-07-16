using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class SavingsAccount : Accounts
    {
        //Constructors
        public SavingsAccount()
        {
            //this is my dafault constructor
        }

        public SavingsAccount(double balance, int number, string accountNumber, int input)
        {
            this.balance = balance;
            this.number = number;
            this.accountType = accountType;
            this.input = input;
        }

        //Methods
        public virtual string SaveAccountInfo()
        {
            this.balance = 898.15;
            this.number = 35791113;
            this.accountType = "Savings";
            return " " + balance;
        }

        public int SaveDeposit()
        {
            input = int.Parse(Console.ReadLine());
            balance += input;
            return input;
        }











    }
}
