namespace _02.BankAccounts.Accounts
{
    using System;
    using System.Collections.Generic;

    using _02.BankAccounts.Customers;

    public class Loan : Account, IDeposit
    {
        public Loan(Customer customer, decimal interestRate, decimal loanAmount)
            : base(customer, interestRate)
        {
            this.Balance = -loanAmount;
        }

        public override decimal CalculateInterestAmount(int periodInMonths)
        {
            int monthsWithInterest;

            if ((this.Customer as PrivateCustomer) != null)
            {
                monthsWithInterest = periodInMonths - 3;
            }
            else if ((this.Customer as Company) != null)
            {
                monthsWithInterest = periodInMonths - 2;
            }
            else
            {
                throw new InvalidOperationException("Can not calculate interest amount for this customer");
            }

            if (monthsWithInterest < 0)
            {
                return 0;
            }

            return monthsWithInterest * this.InterestRate * this.Balance;
        }

        public void DepositMoney(decimal amount)
        {
            this.Balance += amount;
        }
    }
}
