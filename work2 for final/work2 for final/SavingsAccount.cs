namespace work2_for_final
{
    public class SavingsAccount : Account
    {
        public decimal InterestRate { get; set; }

        public SavingsAccount(string accountNumber, Customer owner, decimal initialBalance, decimal interestRate)
            : base(accountNumber, owner, initialBalance)
        {
            InterestRate = interestRate;
        }

        public void ApplyInterest()
        {
            Balance += Balance * InterestRate / 100;
        }
    }
}
