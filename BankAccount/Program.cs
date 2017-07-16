using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckingAccount checkBalance = new CheckingAccount(535.78, 24681013, "Checking", 5);
            ///need input inside the method, but for some reason it doesn't matter what number is there because it does not effect my program. not sure why.
            ///ex. 5 for checking account and 23 for savings (random numbers)
            SavingsAccount saveBalance = new SavingsAccount(898.15, 35791113, "Savings", 23);
            Client userClient = new Client();

            string transInput = "";//transInput is the users input if they have another transaction or not (YES/NO)

            do
            {
            Console.WriteLine("1. View Client Information");
            Console.WriteLine("2. View Account Balance");
            Console.WriteLine("3. Deposit Funds");
            Console.WriteLine("4. Withdraw Funds");
            Console.WriteLine("5. Exit");
            Console.WriteLine("Please enter a number for the action you would like to perfom.");

            int userInput = int.Parse(Console.ReadLine());
            
            string accountInput = " ";//accountInput is when the user types "C" or "S" for which account they would like to perform there action in
            switch (userInput)
            {
                case 1:
                    userClient.ClientInfo();
                    Console.WriteLine(userClient.Name);
                    Console.WriteLine(userClient.Address);
                    Console.WriteLine(userClient.TelephoneNumber);
                    Console.WriteLine("Do you have another transaction? YES/NO");
                    transInput = Console.ReadLine().ToUpper();
                    break;

                case 2:
                    Console.WriteLine("Would you like the balance of your Checking Account or Savings Account? Enter C for Checking or S for Savings.");
                    accountInput = Console.ReadLine().ToUpper();
                    if (accountInput == "C")
                    {
                        checkBalance.AccountInfo();
                        Console.WriteLine(checkBalance.Balance);
                    }
                    else if (accountInput == "S")
                    {
                        saveBalance.SaveAccountInfo();
                        Console.WriteLine(saveBalance.Balance);
                    }
                    Console.WriteLine("Do you have another transaction? YES/NO");
                    transInput = Console.ReadLine().ToUpper();
                    break;

                case 3:
                    Console.WriteLine("Which account would you like to deposit funds into? Enter C for Checking or S for Savings.");
                    accountInput = Console.ReadLine().ToUpper();
                    if (accountInput == "C")
                    {
                        Console.WriteLine("Please enter the amount you would like to deposit.");
                        checkBalance.Deposit();
                        Console.WriteLine("Your new balance is " + checkBalance.Balance);
                    }
                    else if (accountInput == "S")
                    {
                        Console.WriteLine("Please enter the amount you would like to deposit.");
                        saveBalance.Deposit();
                        Console.WriteLine("Your new balance is " + saveBalance.Balance);
                    }
                    Console.WriteLine("Do you have another transaction? YES/NO");
                    transInput = Console.ReadLine().ToUpper();
                    break;

                case 4:
                    Console.WriteLine("Which account would you like to withdraw funds from? Enter C for Checking or S for Savings.");
                    accountInput = Console.ReadLine().ToUpper();
                    if (accountInput == "C")
                    {
                        Console.WriteLine("Please enter the amount you would like to withdraw.");
                        checkBalance.Withdraw();
                        Console.WriteLine("Your new balance is " + checkBalance.Balance);
                    }
                    else if (accountInput == "S")
                    {
                        Console.WriteLine("Please enter the amount you would like to withdraw.");
                        saveBalance.Withdraw();
                        Console.WriteLine("Your new balance is " + saveBalance.Balance);
                    }
                    Console.WriteLine("Do you have another transaction? YES/NO");
                    transInput = Console.ReadLine().ToUpper();
                    break;

                case 5:
                    Console.WriteLine("Goodbye!");                  
                    break;
            }



            }

            while (transInput == "YES");

        }
    }
}



















