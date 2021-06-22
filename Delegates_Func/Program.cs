using System;
using System.Collections.Generic;
using System.Linq;
using Delegates_Func.Entities;

namespace Delegates_Func
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * Fazer um programa que a partir de uma lista de produtos
             * gere uma nova lista contendo os nomes dos produtos em 
             * caixa alta
            */

            //Versão 1
            Console.WriteLine("---------------------Versão 1---------------------");
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            /*
             * A função select retorna um IEnumerable, por isso nesse caso
             * é necessário converter esse IEnumerable(que é uma classe
             * mais genérica) para uma lista
            */
            List<string> result = list.Select(NameUpper).ToList();

            foreach(string s in result)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine();
            //Versão 2
            Console.WriteLine("---------------------Versão 2---------------------");

            List<Product> list2 = new List<Product>();

            list2.Add(new Product("Laptop", 12000.00));
            list2.Add(new Product("Smartphone", 6700.00));
            list2.Add(new Product("Smartwatch", 900.50));
            list2.Add(new Product("Camera", 7200.00));

            Func<Product, string> func2 = NameUpper;

            List<string> result2 = list2.Select (func2).ToList();

            foreach (string s in result2)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine();
            //Versão 3 - Utilizando expressão Lambda
            Console.WriteLine("------------------------Versão 3---------------------------");

            List<Product> list3 = new List<Product>();

            list3.Add(new Product("Desktop", 3900.00));
            list3.Add(new Product("Monitor", 1800.00));
            list3.Add(new Product("Home Theater", 4500.50));
            list3.Add(new Product("Keyboard", 800.90));

            Func<Product, string> func3 = p => p.Name.ToUpper();

            List<string> result3 = list3.Select (func3).ToList();

            foreach (string s in result3)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine();
            //Versão 4 - Utilizando expressão Lambda inline
            Console.WriteLine("------------------------Versão 4---------------------------");

            List<Product> list4 = new List<Product>();

            list4.Add(new Product("House", 500000.00));
            list4.Add(new Product("Farm", 2800000.00));
            list4.Add(new Product("Duplex", 1200000.50));
            list4.Add(new Product("Car", 130000.90));


            List<string> result4 = list4.Select(p => p.Name.ToUpper()).ToList();

            foreach (string s in result4)
            {
                Console.WriteLine(s);
            }

        }
        static string NameUpper(Product p)
        {
            return p.Name.ToUpper();
        }
    }
}
