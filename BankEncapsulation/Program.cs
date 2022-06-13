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
            daBank.Deposit();
            Console.WriteLine($"your account balance is: ${daBank.GetBalance()}");
            daBank.Withdraw();
            Console.WriteLine($"your account balance is: ${daBank.GetBalance()}");
        }
    }
}
