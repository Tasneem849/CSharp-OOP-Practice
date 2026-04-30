using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice
{
    // A Bank Account Class that simulates
    // deposit, withdrawal, and balance checking.

    class BankAccount
    {
        decimal Balance { get; set; } = 0;

        public BankAccount(decimal _balance=0)
        {
            this.Balance = _balance;
        }

        public void Deposit(decimal amount)
        {
            this.Balance += amount;
            Console.WriteLine($"An amount of {amount} has been deposited successfully to your balance.");
            Console.WriteLine($"Your new balance is {this.Balance}.\n");
        }

        public void Withdraw(decimal amount)
        {
            if (this.Balance < amount)
            {
                Console.WriteLine("Insufficient balance.\n");
                return;
            }

            this.Balance -= amount;
            Console.WriteLine($"An amount of {amount} has been withdrawn successfully from your balance.");
            Console.WriteLine($"Your new balance is {this.Balance}.\n");
        }

        public void BalanceCheck()
        {
            Console.WriteLine($"Your balance is {this.Balance}.\n");
        }
    }
}


/*
static void Main(string[] args)
    {
        BankAccount bankAccount1 = new BankAccount();

        bankAccount1.BalanceCheck();
        bankAccount1.Deposit(125.241M);
        bankAccount1.Withdraw(100.5M);
        bankAccount1.Withdraw(3000M);       //Triggers Insufficient Balance
    } 
*/
