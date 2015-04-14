namespace _02.BankAccounts
{
    using System;
    using System.Collections.Generic;

    using _02.BankAccounts.Customers;

    public class ConsoleApp
    {
        public static void Main()
        {
            Bank bankDSK = new Bank("BankaDSK");
            Customer pesho = new PrivateCustomer("Pesho");
            Customer peshoLtd = new Company("PeshoLtd");

            bankDSK.AddNewCustomer(pesho);
            bankDSK.AddNewCustomer(peshoLtd);

            bankDSK.OpenLoanAccount(pesho, 2000, 0.05M);
            bankDSK.OpenLoanAccount(peshoLtd, 2000, 0.05M);

            // Loan and Mortgage have negative InterestAmount
            foreach (var ac in pesho.Accounts)
            {
                Console.WriteLine(ac.CalculateInterestAmount(18));
            }

            foreach (var ac in peshoLtd.Accounts)
            {
                Console.WriteLine(ac.CalculateInterestAmount(18));
            }
        }
    }
}
