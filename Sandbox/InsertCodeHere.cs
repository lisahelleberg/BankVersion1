using System;

namespace Sandbox
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            BankAccount account1 = new BankAccount("Lisa", 0, 123456987);
            BankAccount account2 = new BankAccount("Peter", 0, 456789321);

            //account1.PrintInformation();
            account2.PrintInformation();

            //account1.Deposit(50);
            //account1.Deposit(180);
            account2.Deposit(240);

            //account1.PrintInformation();
            account2.PrintInformation();

            //account1.Withdraw(90);

            //account2.SetCreditGranted(-5000);

            //account1.PrintInformation();
            //account2.PrintInformation();

            //account1.Withdraw(200);
            account2.Withdraw(150);

            account2.PrintInformation();

            account2.Withdraw(200);

            //account1.PrintInformation();
            //account2.PrintInformation();

            // The LAST line of code should be ABOVE this line
        }
    }
}
