namespace _02.BankAccounts.Accounts
{
    using System.Collections.Generic;

    using _02.BankAccounts.Customers;

    public abstract class Account : ICalculateIntrestAmount
    {
        public Account(Customer customer, decimal interestRate)
        {
            this.Customer = customer;
            this.InterestRate = interestRate;
        }

        public decimal Balance { get; internal set; }

        public decimal InterestRate { get; internal set; }

        public Customer Customer { get; internal set; }

        public abstract decimal CalculateInterestAmount(int periodInMonths);
    }
}
