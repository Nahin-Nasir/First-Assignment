using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Assignment
{
    class Bank
    {
        private string bankName;
        private Account[] myBank;

        public Bank(string name, int size)
        {
            this.bankName = name;
            myBank = new Account[size];
        }
        public string BankName
        {
            set { this.bankName = value; }
            get { return this.bankName; }
        }
        public Account[] MyBank
        {
            set { this.myBank = value; }
            get { return this.myBank; }
        }

        public void AddAccount(Account account)
        {
            for (int i = 0; i < MyBank.Length; i++)
            {
                if (MyBank[i] == null)
                {
                    MyBank[i] = account;
                    Console.WriteLine("Account Created");
                    break;
                }
            }
        }

        public void DeleteAccount(int accountNumber)
        {
            for (int i = 0; i < MyBank.Length; i++)
            {
                if (MyBank[i].AccountNumber == accountNumber)
                {
                    MyBank[i] = null;
                    Console.WriteLine("Account Deleted");
                }

            }

        }
        public void Transection(int choice)
        {
            int amount,receiver;
            int accountnumber = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < MyBank.Length; i++)
            {
                if (MyBank[i] != MyBank[accountnumber])

                {
                    Console.WriteLine("Account does not exist");
                    break;
                }

                else if (MyBank[i] == MyBank[accountnumber])
                {
                    if (choice == 1)
                    {

                        Console.WriteLine("Enter amount");
                        amount = Convert.ToInt32(Console.ReadLine());
                        MyBank[accountnumber].Withdraw(amount);
                    }

                    else if (choice == 2)
                    {
                        Console.WriteLine("Enter amount");
                        amount = Convert.ToInt32(Console.ReadLine());
                        MyBank[accountnumber].Deposit(amount);
                    }

                    else if (choice == 3)
                    {
                        Console.WriteLine("Enter amount and revceiver id");
                        amount = Convert.ToInt32(Console.ReadLine());
                        receiver = Convert.ToInt32(Console.ReadLine());
                        MyBank[accountnumber].Transfer(amount, receiver);
                    }

                    else
                        Console.WriteLine("invalid request");

                    break;
                }
            }

        }
        public void PrintAccountDetailes()
        {
            for (int i = 0; i < MyBank.Length; i++)
            {
                if (MyBank[i] == null)
                {
                    continue;
                }
                MyBank[i].ShowAccountInformation();
            }

        }




    }


}

