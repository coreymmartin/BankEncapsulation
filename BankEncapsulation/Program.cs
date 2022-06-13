using System;
using System.Collections.Generic;
using System.Text;

namespace BankEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount daBank = new BankAccount();
            bool gotDep = false;
            double dep = 0;
            do { 
                Console.WriteLine("Please enter deposit amount");
                gotDep = double.TryParse(Console.ReadLine(), out dep); 
            } while (!gotDep);
            daBank.Deposit(dep);
            Console.WriteLine($"your new account balance is: {daBank.GetBalance()}");
        }
    }
}
