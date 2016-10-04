using System;

namespace Sandbox
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            BankAccount account1 = new BankAccount("Lisa", 0, 123456987);

            account1.PrintInformation();

            account1.Deposit(50);
            account1.Deposit(180);

            account1.PrintInformation();


            // The LAST line of code should be ABOVE this line
        }
    }
}
