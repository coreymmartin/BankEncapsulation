using System;
using System.Collections.Generic;
using System.Text;

namespace BankEncapsulation
{
    public class BankAccount
    {
        private double balance = 0;

        public void Deposit()
        {
            bool gotDep = false;
            double dep = 0;
            do
            {
                //Console.Clear();
                Console.WriteLine("Please enter deposit amount");
                gotDep = double.TryParse(Console.ReadLine(), out dep);
            } while (!gotDep);
            balance += dep;
            Console.WriteLine($"your new account balace is ${balance}\npress enter to continue\n");
            Console.ReadLine();
        }

        public void Withdraw()
        {
            bool gotWith = false;
            double with = 0;
            do
            {
                //Console.Clear();
                Console.WriteLine("Please enter withdraw amount");
                gotWith = double.TryParse(Console.ReadLine(), out with);
            } while (!gotWith);
            if (with > balance)
            {
                Console.WriteLine($"unable to withdraw ${with}, available balance: ${balance}");
            }
            else
            {
                balance -= with;
                Console.WriteLine($"your new account balace is ${balance}");
            }
            Console.WriteLine("\npress enter to continue\n");
            Console.ReadLine();
        }

        public double GetBalance()
        {
            return balance;
        }

    }
}
