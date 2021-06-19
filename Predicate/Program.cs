using System;
using System.Collections.Generic;
using Predicate.Entities;

namespace Predicate
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            Console.WriteLine("Before RemoveAll");
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
            /*
             * Predicate é um delegate(Uma função anônima) que recebe um objeto
             * e retorna um valor booleano
            */
            list.RemoveAll(p => p.Price >= 100.00);

            Console.WriteLine();
            Console.WriteLine("After RemoveAll");
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }
    }
}
