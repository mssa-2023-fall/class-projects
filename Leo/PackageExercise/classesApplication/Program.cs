using System;

namespace MySuperBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Leo", 1000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}.");

            account.MakeWithdrawl(120, DateTime.Now, "Hammock");
            Console.WriteLine(account.Balance);

            
            account.MakeWithdrawl(50, DateTime.Now, "Xbox Game");
            Console.WriteLine(account.Balance);

            Console.WriteLine(account.GetAccountHistory());

            // Test for a negative balance:
            /*
            try
            {
                account.MakeWithdrawl(75000, DateTime.Now, "Attempt to overdraw");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Exception caught trying to overdaw");
                Console.WriteLine(e.ToString());
            }

            // Test that the initial balances must be positive
            try
            {
                var invalidAccount = new BankAccount("inavlid", -55);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Exception caught creating account with negative balance");
                Console.WriteLine(e.ToString());
            }
            */
        }
    }
}