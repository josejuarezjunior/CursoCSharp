using System;
using Heranca.Entities;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(1080, "Roberta", 100.00, 500.00);
            Console.WriteLine("Balance: " + account.Balance);
            Console.WriteLine("Account number: " + account.Number);
            Console.WriteLine("Holder: " + account.Holder);

            /*A operação abaixo não é possível, pois a alteração do saldo não está
            ** acessível fora da classe "Account" e sua sub-classe, "BusinessAccount".
            **
            **account.Balance = 650.00;
            */
        }
    }
}