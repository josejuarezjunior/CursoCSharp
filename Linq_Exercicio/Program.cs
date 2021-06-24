using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
using System.Linq;

namespace Linq_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            List<Product> list = new List<Product>();

            /*
             * Exemplo do arquivo CSV em "c:\temp\in.txt"
             * 
             * Tv,900.00
             * Mouse,50.00
             * Tablet,350.50
             * HD Case,80.90
             * Computer,850.00
             * Monitor,290.00
            */

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                    list.Add(new Product(name, price));
                }
            }

            //Encontrando o valor médio dos preços dos produtos
            //Comando DefaultIfEmpty é inserido caso a lista seja vazia.
            var avg = list.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Average price = " + avg.ToString("F2",CultureInfo.InvariantCulture));

            var names = list.Where(p => p.Price < avg).OrderByDescending(p => p.Name).Select(p => p.Name);
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
