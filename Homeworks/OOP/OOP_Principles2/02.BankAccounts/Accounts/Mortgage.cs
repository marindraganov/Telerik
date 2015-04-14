namespace _02.BankAccounts.Accounts
{
    using System;

    using _02.BankAccounts.Customers;

    public class Mortgage : Account, IDeposit
    {
        public Mortgage(Customer customer, decimal interestRate, decimal mortgageAmount)
            : base(customer, interestRate)
        {
            this.Balance = -mortgageAmount;
        }

        public void DepositMoney(decimal amount)
        {
            this.Balance += amount;
        }

        public override decimal CalculateInterestAmount(int periodInMonths)
        {
            if ((this.Customer as PrivateCustomer) != null)
            {
                if (periodInMonths <= 6)
                {
                    return 0;
                }
                else
                {
                    return (periodInMonths - 6) * this.Balance * this.InterestRate;
                }
            }
            else if ((this.Customer as Company) != null)
            {
                if (periodInMonths < 12)
                {
                    return 0.5M * periodInMonths * this.Balance * this.InterestRate;
                }
                else
                {
                    return (periodInMonths - 6) * this.Balance * this.InterestRate;
                }
            }
            else
            {
                throw new InvalidOperationException("Can not calculate interest amount for this customer");
            }
        }
    }
}
