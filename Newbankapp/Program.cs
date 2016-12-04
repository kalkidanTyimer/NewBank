using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newbankapp
{
   
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*******************");
            Console.WriteLine("Welcome to my Bank");
            Console.WriteLine("0. Exit");
            Console.WriteLine("1. Create Account");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdraw");
            var choice = Console.ReadLine();
            switch (choice)
                {
                case "0":
                    Console.WriteLine("Have a greate day!");
                    return;
                case "1":
                    Console.WriteLine("Email Address");
                    var emailadress = Console.ReadLine();
                    var checkingAccount = new Account();
                    checkingAccount.EmailAddress = "test@test.com";
                    checkingAccount.AccountType = Typeofaccounts.Checking;
                    checkingAccount.Deposit(1000.20M);
                    Console.WriteLine($"Account Number/; {checkingAccount.AccountNumber},Balance: {checkingAccount.Balance:c}");
                    break;
              default:
                    break;
            }
            

            var savingsAccount = new Account();
            savingsAccount.EmailAddress = "test2@test.com";
            savingsAccount.AccountType = Typeofaccounts.Saving;
            savingsAccount.Deposit(200M);
            Console.WriteLine($"Account Number/; {savingsAccount.AccountNumber},Balance: {savingsAccount.Balance:c}");
        }
    }
}
