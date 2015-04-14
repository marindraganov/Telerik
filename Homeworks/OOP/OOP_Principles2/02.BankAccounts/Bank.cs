namespace _02.BankAccounts
{
    using System;
    using System.Collections.Generic;

    using _02.BankAccounts.Accounts;
    using _02.BankAccounts.Customers;  

    public class Bank
    {
        public Bank(string name)
        {
            this.Name = name;
            this.Customers = new List<Customer>();
            this.Accounts = new List<Account>();
        }

        public string Name { get; set; }

        public List<Customer> Customers { get; private set; }

        public List<Account> Accounts { get; private set; }

        public void AddNewCustomer(Customer customer)
        {
            this.Customers.Add(customer);
        }

        public void OpenLoanAccount(Customer customer, decimal loanAmount, decimal interestRate)
        {
            if (this.Customers.IndexOf(customer) < 0)
            {
                throw new InvalidOperationException("This customer is not client to our bank!");
            }
            else
            {
                Account loanAccount = new Loan(customer, interestRate, 2000);
                this.Accounts.Add(loanAccount);
                customer.Accounts.Add(loanAccount);
            }
        }
    }
}