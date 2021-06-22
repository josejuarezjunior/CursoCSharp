using System;
using System.Collections.Generic;
using Delegates_Action.Entities;
using System.Collections.Generic;

namespace Delegates_Action
{
    class Program
    {
        static void Main(string[] args)
        {
            //Versão 1 - Utilizando uma função auxiliar (Update Price)
            Console.WriteLine("------------------------Versão 1---------------------------");
            List<Product> list1 = new List<Product>();

            list1.Add(new Product("TV", 900.00));
            list1.Add(new Product("Mouse", 50.00));
            list1.Add(new Product("Tablet", 350.50));
            list1.Add(new Product("HD Case", 80.90));

            list1.ForEach(UpdatePrice);
            foreach (Product p in list1)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine();
            //Versão 2 - Objeto Delegate do tipo Action
            Console.WriteLine("------------------------Versão 2---------------------------");

            List<Product> list2 = new List<Product>();

            list2.Add(new Product("Laptop", 12000.00));
            list2.Add(new Product("Smartphone", 6700.00));
            list2.Add(new Product("Smartwatch", 900.50));
            list2.Add(new Product("Camera", 7200.00));

            Action<Product> act2 = UpdatePrice;

            list2.ForEach(act2);
            foreach (Product p in list2)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine();
            //Versão 3 - Utilizando expressão Lambda
            Console.WriteLine("------------------------Versão 3---------------------------");

            List<Product> list3 = new List<Product>();

            list3.Add(new Product("Desktop", 3900.00));
            list3.Add(new Product("Monitor", 1800.00));
            list3.Add(new Product("Home Theater", 4500.50));
            list3.Add(new Product("Keyboard", 800.90));

            /*
             * Como é uma expressão Lambda com retorno void, precisa
             * estar entre chaves({}).
            */
            Action<Product> act3 = p3 => { p3.Price += p3.Price * 0.1; };

            list3.ForEach(act3);
            foreach (Product p in list3)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine();
            //Versão 4 - Utilizando expressão Lambda inline
            Console.WriteLine("------------------------Versão 4---------------------------");

            List<Product> list4 = new List<Product>();

            list4.Add(new Product("House", 500000.00));
            list4.Add(new Product("Farm", 2800000.00));
            list4.Add(new Product("Duplex", 1200000.50));
            list4.Add(new Product("Car", 130000.90));

            /*
             * Como é uma expressão Lambda com retorno void, precisa
             * estar entre chaves({}).
            */
            list4.ForEach(p4 => { p4.Price += p4.Price * 0.1; });
            foreach (Product p in list4)
            {
                Console.WriteLine(p);
            }
        }
        //Função auxiliar que aumenta o preço em 10%
        static void UpdatePrice(Product p)
        {
            p.Price += p.Price * 0.1;
        }
    }

}
