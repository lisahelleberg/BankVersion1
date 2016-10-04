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
        public bool creditGranted;
        public double creditMax;

        // Constructor
        public BankAccount(string name, double balance, int accountno)
        {
            this.name = name;
            this.balance = balance;
            this.accountno = accountno;
            this.accountIsNegative = false;
            this.creditGranted = false;
            this.creditMax = creditMax;
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

        // Credit granted
        public void SetCreditGranted(double creditMax)
        {
            this.creditGranted = true;
            Console.WriteLine("You have been granted a credit of {0} £, {1}!", creditMax, name);
            Console.WriteLine();
        }
        
        // Method for deposit
        public void Deposit(double DepositAmount)
        {
            this.balance = this.balance + DepositAmount;
            Console.WriteLine("You have deposited {0} £", DepositAmount);
            Console.WriteLine();
        }

        // Method for withdraw
        public void Withdraw(double WithdrawAmount)
        {
            if (!creditGranted && this.balance - WithdrawAmount < 0)
            { 
                Console.WriteLine("You are trying to withdraw to much money. You can withdraw a maximum of {0} £", balance);
                Console.WriteLine();
            }

            else if (creditGranted && this.balance - WithdrawAmount < 0)
            {
                this.balance = this.balance - WithdrawAmount;
                Console.WriteLine("You are now using your credit!");
                Console.WriteLine("You have {0} £ left to use", (creditMax - WithdrawAmount));
                Console.WriteLine();
            }

            else
            {
                this.balance = this.balance - WithdrawAmount;
                Console.WriteLine("You have withdrawn {0} £", WithdrawAmount);
                Console.WriteLine();
            }
        }


        // Printout
        public void PrintInformation()
        {
            Console.WriteLine("Account no {0} is owned by {1}.", accountno, name);
            Console.WriteLine("The balance of the account is {0} £", balance);
            Console.WriteLine();
        }
    }



}
