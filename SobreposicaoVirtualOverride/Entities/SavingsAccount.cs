namespace SobreposicaoVirtualOverride.Entities
{
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        /*A palavra "override" aqui, indica que o método "Withdraw" da super-classe
        **está sendo sobrescrevido aqui. Ou seja, o método terá comportamento diferente.
        */
        public override void Withdraw(double amount)
        {
            Balance -= amount;
        }
    }
}