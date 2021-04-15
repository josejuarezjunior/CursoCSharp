using System;

namespace TratamentoExcessao
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tratamento excessões , simples exemplo
            Console.WriteLine("##### Division of two numbers ######");

            bool correto = false;
            do
            {
                try
                {
                    Console.Write("Type a number: ");
                    double n1 = int.Parse(Console.ReadLine());
                    Console.Write("Type another number: ");
                    double n2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("--------------------------------------");
                    double division = n1 / n2;
                    correto = true;
                    Console.WriteLine($"The division of {n1} by {n2} is {division}.");
                }
                catch (FormatException)
                {
                    Console.WriteLine("You must type a number!");
                }
            }
            while (!correto);

        }
    }
}