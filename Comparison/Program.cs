using System;
using System.Globalization;
using System.Collections.Generic;
using Comparison.Entities;

namespace Comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Notebook", 1200.00));
            list.Add(new Product("Tablet", 450.00));

            /*
             * Para ordenar a lista - Só funciona se o tipo dessa lista implementa
             * a interface IComparable
            */
            list.Sort();

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }
    }
}
