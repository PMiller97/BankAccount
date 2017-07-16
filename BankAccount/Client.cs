using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Client
    {
        //3 Fields
        private string name;
        private string address;
        private string telephoneNumber;

        //3 Properties
        public string Name
        {
            get { return this.name; }
        }
        public string Address
        {
            get { return this.address; }
        }
        public string TelephoneNumber
        {
            get { return this.telephoneNumber; }
        }

        //Constructor
        public Client()
        {
            //this is my default constructor
        }

        public Client(string name, string address, string telephoneNumber)
        {
            this.name = name;
            this.address = address;
            this.telephoneNumber = telephoneNumber;
        }

        //Method
        public void ClientInfo()
        {
            this.name = "Paige Miller";
            this.address = "123 Numbers Lane";
            this.telephoneNumber = "(330)-123-4567";
        }















    }
}
