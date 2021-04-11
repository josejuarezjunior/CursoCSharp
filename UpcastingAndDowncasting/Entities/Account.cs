namespace UpcastingAndDowncasting.Entities
{
    class Account
    {
        //Attibutes
        public int Number { get; private set; }//Número da conta
        public string Holder { get; private set; }//Titular da conta
        public double Balance { get; protected set; }//Saldo - O modificador de acesso "protected", indica que  esse dado somente será acessado na classe ou em sub-classes!

        //Constructors
        public Account()
        {
        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        //Methods
        public void Withdraw(double amount)//Saque
        {
            Balance -= amount;
        }

        public void Deposit(double amount)//Depósito
        {
            Balance += amount;
        }

    }
}