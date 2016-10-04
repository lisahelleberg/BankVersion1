using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    public class BankAccount
    {
        // Instance fields
        private string name;
        private double balance;
        private int accountno;
        private bool accountIsNegative;

        // Constructor
        public BankAccount(string name, double balance, int accountno)
        {
            this.name = name;
            this.balance = balance;
            this.accountno = accountno;
            this.accountIsNegative = false;
        }

        public string GetName()
        {
            return name;
        }

        public double GetBalance()
        {
            return balance;
        }

        public int GetAccountno()
        {
            return accountno;
        }

        public bool GetAccountIsNegative()
        {
            return accountIsNegative;
        }

        // Method for deposit
        public void Deposit(double DepositAmount)
        {
            this.balance = this.balance + DepositAmount;
        }

        // Method for withdraw
        public void Withdraw(double WithdrawAmount)
        {
            if (this.balance - WithdrawAmount < 0)
            {
                Console.WriteLine("Overtræk. Du kan hæve op til {0} kr", balance);
                Console.WriteLine();
            }

            else
            {
                this.balance = this.balance - WithdrawAmount;
            }
        }

        // Printout
        public void PrintInformation()
        {
            Console.WriteLine("Account no {0} is owned by {1}.", accountno, name);
            Console.WriteLine("The balance of the account is {0} kr", balance);
            Console.WriteLine();
        }
    }



}
