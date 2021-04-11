namespace UpcastingAndDowncasting.Entities
{
    class BusinessAccount : Account
    /* ":  Account" Informa que a classe atual herdará o comportamento dess classe
    ** indicada. Nesse caso "Account" é a super-classe e "BusinessAccount" é a sub-classe.
    */
    {
        //Attributes
        public double LoanLimit { get; set; }

        //Constructors
        public BusinessAccount()
        {
        }

        //O uso do "base", possibilita chamar construtores da superclasse.
        public BusinessAccount(int number, string holder, double balance, double LoanLimit) : base(number, holder, balance)
        {
            LoanLimit = LoanLimit;
        }

        //Methods
        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }

        }

    }
}
