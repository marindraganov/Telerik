namespace _02.BankAccounts.Customers
{
    using System.Collections.Generic;

    using _02.BankAccounts.Accounts;
   
    public abstract class Customer
    {
        public Customer(string name)
        {
            this.Name = name;
            this.Accounts = new List<Account>();
        }

        public string Name { get; private set; }

        public List<Account> Accounts { get; set; }
    }
}
