using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            Bank mB = new Bank("MY bank", 100);
            mB.AddAccount(new Account("akib", 5000, new Address("21", "10", "dhaka", "bangla")));
            mB.AddAccount(new Account("anik", 4000, new Address("45", "1220", "dhaka", "bangla")));
            mB.PrintAccountDetailes();
            //mB.DeleteAccount(1);
            //mB.DeleteAccount(2);

            // mB.PrintAccountDetail
            //Console.WriteLine("Enter 1 for withdraw");
            //Console.WriteLine("Enter 2 for deposit");
            //Console.WriteLine("Enter 3 for transfer");
            choice = Convert.ToInt32(Console.ReadLine());
            mB.Transection(choice);

            mB.PrintAccountDetailes();
            Console.ReadKey();

        }
        //    Address address = new Address();
        //    Console.WriteLine(address.GetAddress());
        //    Console.ReadKey();
        //}

    }
}

