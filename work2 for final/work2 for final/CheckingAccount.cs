using System;

namespace work2_for_final
{
    public class CheckingAccount : Account
    {
        public decimal MonthlyFee { get; set; }

        public CheckingAccount(string accountNumber, Customer owner, decimal initialBalance, decimal monthlyFee)
            : base(accountNumber, owner, initialBalance)
        {
            MonthlyFee = monthlyFee;
        }

        public void DeductFee()
        {
            if (Balance >= MonthlyFee)
            {
                Balance -= MonthlyFee;
            }
            else
            {
                throw new InvalidOperationException("არასაკმარისი თანხები თვიური სარგებლის დასაკლებად");
            }
        }
    }
}
