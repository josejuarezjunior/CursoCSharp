using System;
using GetHashCode_E_Equals.Entities;

namespace GetHashCode_E_Equals
{
    class Program
    {
        static void Main(string[] args)
        {

            
            
            Client a = new Client { Name = "Maria", Email = "Maria@gmail.com" };
            Client b = new Client { Name = "Alex", Email = "Alex@gmail.com" };

            /*
             * GetHashCode e Equals
             * São operações da classe Object utilizadas para comparar se um objeto
             * é igual a outro
             * 
             * Equals: lento, resposta 100%
             * Método que compara se o objeto é igual a outro, retornando
             * true ou false.
             * 
             * GetHashCode: rápido, porém resposta positiva não é 100%
             * Método que retorna um número inteiro representando um código 
             * gerado a partir das informações do objeto
             * 
             * Os tipos pré-definidos(int, double, string..etc) já possuem 
             * implementação para essas operações. 
             * Classes e structs personalizados precisam sobrepô-las.
            */

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
        }
    }
}
