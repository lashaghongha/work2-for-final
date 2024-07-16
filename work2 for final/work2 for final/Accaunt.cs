using System;

namespace work2_for_final
{
    public class Account
    {
        public string AccountNumber { get; set; }
        protected decimal Balance { get; set; }
        public Customer Owner { get; set; }

        public Account(string accountNumber, Customer owner, decimal initialBalance)
        {
            AccountNumber = accountNumber;
            Owner = owner;
            Balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("დეპოზიტის თანხა უნდა იყოს დადებითი");
            Balance += amount;
        }

        public virtual void Withdraw(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("გატანის თანხა უნდა იყოს დადებითი");
            if (amount > Balance)
                throw new InvalidOperationException("არასაკმარისი თანხები");
            Balance -= amount;
        }

        public void PrintBalance()
        {
            Console.WriteLine($"ანგარიში: {AccountNumber}, ბალანსი: {Balance}");
        }
    }
}
