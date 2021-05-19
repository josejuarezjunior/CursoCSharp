using System;
using GetHashCode_E_Equals.Entities;

namespace GetHashCode_E_Equals
{
    class Program
    {
        static void Main(string[] args)
        {

            //Adcionar mais comentários!!!!
            Client a = new Client { Name = "Maria", Email = "Maria@gmail.com" };
            Client b = new Client { Name = "Alex", Email = "Alex@gmail.com" };

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
        }
    }
}
