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
            bool userActive = true;
            bool acceptableSelection;
            int userSelection;
            do {
                Console.Clear();
                Console.WriteLine("welcome to your bank account. \nplease select an option\n" +
                    "\n1: Account Balance\n2: Deposit Funds\n3: Withdraw Funds\n4: Exit");
                acceptableSelection = false;
                userSelection = 0;
                do {
                    Console.Write("user selection: ");
                    acceptableSelection = int.TryParse(Console.ReadLine(), out userSelection);} 
                while (!acceptableSelection);
                switch (userSelection) {
                    case 1:
                        Console.WriteLine($"your account balance is: ${daBank.GetBalance()}.\npress enter to continue\n");
                        Console.ReadLine();
                        break;
                    case 2:
                        daBank.Deposit();
                        break;
                    case 3:
                        daBank.Withdraw();
                        break;
                    case 4:
                        Console.WriteLine("\nthank you, please come again\n");
                        userActive = false;
                        break;
                    default:
                        break;
                }
            } while (userActive);
        }
    }
}
