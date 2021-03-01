using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Assignment
{
    class Account
    {
        private int accountNumber;
        private string accountName;
        private double balance;
        private Address address;

        public Account(int accountNumber, string accountName, double balance, Address address)
        {
            this.accountNumber = accountNumber;
            this.accountName = accountName;
            this.balance = balance;
            this.address = address;
        }

        public int AccountNumber
        {
            set { this.accountNumber = value; }
            get { return this.accountNumber; }
        }

        public string AccountName
        {
            set { this.accountName = value; }
            get { return this.accountName; }

        }

        public double Balance
        {
            set { this.balance = value; }
            get { return this.balance; }

        }


        public Address Address
        {
            set { this.address = value; }
            get { return this.address; }

        }
        public void Withdraw(double amount)
        {
            if (this.Balance - amount >= 500)
            {
                this.Balance = Balance - amount;
            }
            else
                Console.WriteLine("your balance is not sufficient");
        }
        public void Deposit(double amount)
        {
            this.Balance=this.Balance + amount;
        
        }
        public void Transfer(double amount, Account receiver)
        {
            receiver.Deposit(amount);
            this.Withdraw(amount);
        
        }
        public void ShowAccountInformation()
        {
            Console.WriteLine("Account Informations: AccountNo-{0},AccountName{1},Balance{2},Adress{4}", this.accountNumber, this.accountName, this.balance, this.address);
        }





    }
}
