using EnumeracaoComposicao.Entities;
using EnumeracaoComposicao.Entities.Enums;
using System;

namespace EnumeracaoComposicao
{
    class Program
    {
        static void Main(string[] args)
        {

            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            Console.WriteLine("---------------------------------------------");

            //Convertendo o tipo enumerado para uma string
            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);

            //Convertendo uma string para um tipo enumerado
            Enum.TryParse(Console.ReadLine(), out OrderStatus os);
            Console.WriteLine(os);
        }
    }
}