using System;
using UpcastingAndDowncasting.Entities;

namespace UpcastingAndDowncasting
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alex", 0.00);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.00, 500.00);

            //UPCASTING - Conversão da sub-classe para super-classe...

            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0.00, 200.00);
            Account acc3 = new SavingsAccount(1004, "Anna", 0.00, 0.01);

            //DOWNCASTING - Conversão da super-classe para a sub-classe.

            BusinessAccount acc4 = (BusinessAccount)acc2;//Casting
            acc4.Loan(100.00);//Empréstimo

            /* 'acc2.Loan(100.00);' Não será possível, pois o objeto é do 
            **tipo Account, que não possui esse método.
            */

            /* 'BusinessAccount acc5 = (BusinessAccount)acc3;'
            ** Irá gerar um erro, pois o objeto atribuído é de tipo
            ** diferente(um é do tipo 'BusinessAccount' e outro do tipo
            ** 'SavingsAccount').
            */

            //Testando se acc3 é uma instância da classe BusinessAccount.
            if (acc3 is BusinessAccount)
            {
                BusinessAccount acc5 = (BusinessAccount)acc3;
                //BusinessAccount acc5 = acc3 as BusinessAccount; **Outra forma de fazer o casting!!!!
                acc5.Loan(200.00);
                Console.WriteLine("Loan!");
            }

            //Testando se acc3 é uma instância da classe SavingsAccount.
            if (acc3 is SavingsAccount)
            {
                //SavingsAccount acc5 = (SavingsAccount)acc3;
                SavingsAccount acc5 = acc3 as SavingsAccount;
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }
        }
    }
}