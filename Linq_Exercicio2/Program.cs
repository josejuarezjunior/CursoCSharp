using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Linq_Exercicio2.Entities;
using System.Globalization;

namespace Linq_Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            List<Employee> list = new List<Employee>();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] fields = sr.ReadLine().Split(',');
                        string name = fields[0];
                        string email = fields[1];
                        double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);
                        list.Add(new Employee(name, email, salary));
                    }
                }

                Console.WriteLine("Enter salary: ");
                double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine($"Email of people whose salary is more than {value}: ");
                var em = list.Where(e => e.Salary > value).Select(e => e.Email);
                foreach (string email in em)
                {
                    Console.WriteLine(email);
                }
                Console.WriteLine();

                var msum = list.Where(e => e.Name[0] == 'M').Sum(e => e.Salary).ToString("F2", CultureInfo.InvariantCulture);
                Console.WriteLine($"Sum of salary of people whose name starts with 'M': {msum}");
                Console.WriteLine();
            }
            catch(IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
