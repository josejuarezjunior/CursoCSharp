namespace SobreposicaoBase.Entities
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

        /*A palavra "override" aqui, indica que o método da subclasse "Withdraw"
        **está sendo sobrescrevido aqui. Ou seja, o método será diferente.
        */
        public override void Withdraw(double amount)
        {
            /*Nesse caso, o uso da palavra "base", utiliza o método da superclasse
            ** e ainda é possível implementar mais operação.
            **Portanto aqui será descontado os $5.00 da superclasse(Account)
            **e mais $2.00. Totalizando assim $7.0.
            */
            base.Withdraw(amount);
            Balance -= 2.0;
        }
    }
}