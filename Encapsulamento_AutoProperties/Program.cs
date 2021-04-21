using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento_AutoProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500.00, 20);

            p.Nome = "TV 4K";

            Console.WriteLine($"O nome do produto é {p.Nome}.");
            Console.WriteLine($"O preço é {p.Preco}.");
            Console.WriteLine($"A quantidade é {p.Quantidade}.");


            /* p.Preco = 450.00; --> Não é possível alterar o valor de preço,
             * devido o encapsulamento.
             * Para alterar o preço, é necessário um método.
            */
        }
    }
}
