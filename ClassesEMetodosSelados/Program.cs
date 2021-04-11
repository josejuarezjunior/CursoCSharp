using System;
using System.Globalization;
using ClassesEMetodosSelados.Entities;

namespace ClassesEMetodosSelados
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(1001, "Alex", 500.0);
            Account acc2 = new SavingsAccount(1002, "Anna", 500.0, 0.01);

            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);

            Console.WriteLine("Saque com taxa da classe Account no valor de $5.00: $" + acc1.Balance.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Saque com taxa da classe Account no valor de $5.00 + $2.00 da classe SavingsAccount: $" + acc2.Balance.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}