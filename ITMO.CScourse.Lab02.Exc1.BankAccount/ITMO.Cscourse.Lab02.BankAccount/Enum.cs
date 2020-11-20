using System;

namespace ITMO.Cscourse.Lab02.BankAccount
{
    public enum AccountType {Checking , Deposit }
    class Enum
    {
        static void Main(string[] args)
        {
            AccountType goldAccount;
            AccountType platinumAccount;

            goldAccount = AccountType.Checking;
            platinumAccount = AccountType.Checking;

            Console.WriteLine("The Customer Account Type is {0}", goldAccount);
            Console.WriteLine("The Customer Account Type is {0}", platinumAccount);

            Console.ReadKey();
        }
    }
}
