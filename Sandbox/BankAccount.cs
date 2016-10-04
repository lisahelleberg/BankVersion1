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

        // Constructor
        public BankAccount()
        {
            this.name = name;
            this.balance = balance;
            this.accountno = accountno;
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

        // Method for deposit
        public void Deposit()
        {

        }

        // Method for withdraw
        public void Withdraw()
        {

        }

        // Printout
        public void PrintInformation()
        {
            Console.WriteLine("Account no {0} is owned by {1}", accountno, name);
        }
    }



}
