namespace _02.BankAccounts.Accounts
{
    using System.Collections.Generic;

    using _02.BankAccounts.Customers;

    public class Deposit : Account, IWithdraw, IDeposit
    {
        public Deposit(Customer customer, decimal interestRate)
            : base(customer, interestRate)
        {
            this.Balance = 0;
        }

        public Deposit(Customer customer, decimal interestRate, decimal depositAmount)
            : base(customer, interestRate)
        {
            this.Balance = depositAmount;
        }

        public override decimal CalculateInterestAmount(int periodInMonths)
        {
            if (this.Balance < 1000)
            {
                return 0;
            }
            else
            {
                return periodInMonths * this.Balance * this.InterestRate;
            }
        }

        public decimal Withdraw(decimal amount)
        {
            // the balance may be negative
            if (this.Balance >= amount)
            {
                this.Balance -= amount;
                return amount;
            }
            else
            {
                System.Console.WriteLine("Not enough money bro!");
                return 0;
            } 
        }

        public void DepositMoney(decimal amount)
        {
            this.Balance += amount;
        }
    }
}
